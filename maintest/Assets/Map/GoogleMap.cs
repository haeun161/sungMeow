using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GoogleApi : MonoBehaviour
{
    public RawImage img;
    string url;

    //public double lat;
    //public double lon;

    //public double first_Lat; //���� ����
    //public double first_Long; //���� �浵
    public double current_Lat; //���� ����
    public double current_Long; //���� �浵

    public WaitForSeconds second;

    private static bool gpsStarted = false;

    LocationInfo location;

    public int zoom = 0;
    public int mapWidth = 2960;
    public int mapHeight = 2960;

    public Sprite newimg;
    public enum mapType { roadmap, satellite, hybrid, terrain }
    public mapType mapSelected;
    public int scale;

    public void Awake()
    {
        second = new WaitForSeconds(1.0f);
    }

    IEnumerator Map()
    {
        url = "https://maps.googleapis.com/maps/api/staticmap?center=" + current_Lat + "," + current_Long +
        "&zoom=" + zoom + "&size=" + mapWidth + "x" + mapHeight + "&scale=" + scale + "&maptype=" + mapSelected +
        "&markers=icongreen%7Clabel:D%7C" + current_Lat + "," + current_Long + //����ġ
        //"&markers=icon:https://goo.gl/5y3S82%7CCanberra+ACTlabel:D%7C37.591898686588785,127.02231168247297" +
        //"&markers=icon:https://goo.gl/5y3S82%7CCanberra+ACTlabel:D%7C37.5912657864989,127.02206239287148" +
        "&markers=icon:https://shorturl.at/blnQ5:D%7C37.5912657864989,127.02206239287148" +
        "&key=AIzaSyATpBKPhD1nbjcXsW0cR-i6EzJTf8xkdpM";
        //"&markers=color:green%7Clabel:D%7C" + lat + "," + lon + "&key=AIzaSyATpBKPhD1nbjcXsW0cR-i6EzJTf8xkdpM";


        WWW www = new WWW(url);
        yield return www;
        img.texture = www.texture;
        //img.SetNativeSize();
    }

    // Start is called before the first frame update
    IEnumerator Start()
    {
        Debug.Log("start");
        img = gameObject.GetComponent<RawImage>();

        StartCoroutine(Map());

        // ������ GPS ��������� ���� üũ
        if (!Input.location.isEnabledByUser)
        {
            Debug.Log("GPS is not enabled");
            yield break;
        }

        //GPS ���� ����
        Input.location.Start();
        Debug.Log("Awaiting initialization");

        //Ȱ��ȭ�� �� ���� ���
        int maxWait = 30;
        while (Input.location.status == LocationServiceStatus.Initializing && maxWait > 0)
        {
            yield return second;
            maxWait -= 1;
        }

        //20�� ������� Ȱ��ȭ �ߴ�
        if (maxWait < 1)
        {
            Debug.Log("Timed out");
            yield break;
        }

        //���� ����
        if (Input.location.status == LocationServiceStatus.Failed)
        {
            Debug.Log("Unable to determine device location");
            yield break;

        }
        else //���� ����
        {
            gpsStarted = true;
            //���� �㰡��, ���� ��ġ ���� �޾ƿ���
            /*
            location = Input.location.lastData;
            first_Lat = location.latitude * 1.0d;
            first_Long = location.longitude * 1.0d;
            gpsStarted = true;
            */

            //���� ��ġ ����
            while (gpsStarted)
            {
                location = Input.location.lastData;
                current_Lat = location.latitude * 1.0d;
                current_Long = location.longitude * 1.0d;
                yield return second;
            }
        }
    }

    //��ġ ���� ����
    public static void StopGPS()
    {
        if (Input.location.isEnabledByUser)
        {
            gpsStarted = false;
            Input.location.Stop();
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}