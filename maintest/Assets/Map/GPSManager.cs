using System.Collections;
using UnityEngine;
 
public class GPSManager : MonoBehaviour {
 
    public static double first_Lat; //���� ����
    public static double first_Long; //���� �浵
    public static double current_Lat; //���� ����
    public static double current_Long; //���� �浵
 
    private static WaitForSeconds second;
 
    private static bool gpsStarted = false;
 
    private static LocationInfo location;
 
    private void Awake () {
        second = new WaitForSeconds (1.0f);
    }
 
    IEnumerator Start () {
        // ������ GPS ��������� ���� üũ
        if (!Input.location.isEnabledByUser) {
            Debug.Log ("GPS is not enabled");
            yield break;
        }
 
        //GPS ���� ����
        Input.location.Start ();
        Debug.Log ("Awaiting initialization");
 
        //Ȱ��ȭ�� �� ���� ���
        int maxWait = 20;
        while (Input.location.status == LocationServiceStatus.Initializing && maxWait > 0) {
            yield return second;
            maxWait -= 1;
        }
 
        //20�� ������� Ȱ��ȭ �ߴ�
        if (maxWait < 1) {
            Debug.Log ("Timed out");
            yield break;
        }
 
        //���� ����
        if (Input.location.status == LocationServiceStatus.Failed) {
            Debug.Log ("Unable to determine device location");
            yield break;
 
        } 
        else {
            //���� �㰡��, ���� ��ġ ���� �޾ƿ���
            location = Input.location.lastData;
            first_Lat = location.latitude * 1.0d;
            first_Long = location.longitude * 1.0d;
            gpsStarted = true;
 
            //���� ��ġ ����
            while (gpsStarted) {
                location = Input.location.lastData;
                current_Lat = location.latitude * 1.0d;
                current_Long = location.longitude * 1.0d;
                yield return second;
            }
        }
    }
 
    //��ġ ���� ����
    public static void StopGPS () {
        if (Input.location.isEnabledByUser) {
            gpsStarted = false;
            Input.location.Stop ();
        }
    }
}