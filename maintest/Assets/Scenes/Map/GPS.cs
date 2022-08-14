using System.Collections;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Android;
using System;
using UnityEngine.SceneManagement;


public class GPS : MonoBehaviour
{
    public bool isUpdating;
    public RawImage img;
    public Text gpsOut;
    string url;
    public WaitForSeconds second;
    public Text debugText;

    public GameObject frame;
    public GameObject HintBtn;
    //public GameObject BlockHint;


    LocationInfo myGPSLocation;
    //float fiveSecondCounter = 0.0f;

    public string LocationName;

    double MyLatitude, MyLongtitude;
    DistUnit unit;

    /**
????* Latitude - �浵, Longtitude - ���� 
????*/
    // public double TargetLatitude, TargetLongtitude; // 37.507839, 127.039864


    LocationInfo location;

    public int zoom = 19;
    public int mapWidth = 2960;
    public int mapHeight = 2960;


    public enum mapType { roadmap, satellite, hybrid, terrain }
    public mapType mapSelected;
    public int scale;

    public static string HintName;


    private void Start()
    {
        frame.SetActive(false);
        HintBtn.SetActive(false);
    }

    private void Update()
    {
        if (!isUpdating)
        {
            img = gameObject.GetComponent<RawImage>();
            StartCoroutine(GetLocation());
            isUpdating = !isUpdating;
        }
    }

    IEnumerator GetLocation()
    {
        if (!Permission.HasUserAuthorizedPermission(Permission.FineLocation))
        {
            Permission.RequestUserPermission(Permission.FineLocation);
            Permission.RequestUserPermission(Permission.CoarseLocation);
        }
        // First, check if user has location service enabled
        if (!Input.location.isEnabledByUser)
            yield return new WaitForSeconds(10);

        // Start service before querying location
        Input.location.Start();

        // Wait until service initializes
        int maxWait = 10;
        while (Input.location.status == LocationServiceStatus.Initializing && maxWait > 0)
        {
            yield return new WaitForSeconds(1);
            maxWait--;
        }

        // Service didn't initialize in 20 seconds
        if (maxWait < 1)
        {
            gpsOut.text = "Timed out";
            print("Timed out");
            yield break;
        }

        // Connection has failed
        if (Input.location.status == LocationServiceStatus.Failed)
        {
            gpsOut.text = "Unable to determine device location";
            print("Unable to determine device location");
            yield break;
        }
        else
        {
            gpsOut.text = "Location: " + Input.location.lastData.latitude + " " + Input.location.lastData.longitude;

            url = "https://maps.googleapis.com/maps/api/staticmap?center=" + Input.location.lastData.latitude + "," + Input.location.lastData.longitude +
            "&zoom=" + zoom + "&size=" + mapWidth + "x" + mapHeight + "&scale=" + scale + "&maptype=" + mapSelected +
            "&markers=color:red%7Cllabel:D%7C" + Input.location.lastData.latitude + "," + Input.location.lastData.longitude + //����ġ

            "&markers=label:S|icon:https%3A%2F%2Fi.imgur.com%2F13M4rVZ.png%7C37.57595, 126.8383" + //����ġ ��ó�� ���� �߰�
            "&markers=label:S|icon:https%3A%2F%2Fi.imgur.com%2F13M4rVZ.png%7C37.591175,127.022247" + //���� //��׸�            
            "&markers=label:S|icon:https%3A%2F%2Fi.imgur.com%2FXUpV1En.png%2FQVT2pqX.png%7C37.591057,127.021561" + //���վȳ��� //��
            "&markers=label:S|icon:https%3A%2F%2Fi.imgur.com%2FXUpV1En.png%2FQVT2pqX.png%7C37.591595,127.022446" + //���ſ���� //��
            "&markers=label:S|icon:https%3A%2F%2Fi.imgur.com%2FnXCYIqh.png%2FQVT2pqX.png%7C37.591972,127.021332" + //���ջ�Ȳ�� //���ڱ�
            "&markers=label:S|icon:https%3A%2F%2Fi.imgur.com%2FnXCYIqh.png%2FQVT2pqX.png%7C37.591278,127.020851" + //�볪���� //���ڱ�
            "&markers=label:S|icon:https%3A%2F%2Fi.imgur.com%2F7oCkbvi.png%2FQVT2pqX.png%7C37.590813,127.021484" + //������ �׸� //����̹�
            "&markers=label:S|icon:https%3A%2F%2Fi.imgur.com%2FfBOChlf.png%2FQVT2pqX.png%7C37.591274,127.020851" + //���ſ��� ���� //�峭��
            "&markers=color:blue%7Cllabel:D%7C" + "37.510284,127.088417" + //�� ����
            "&key=AIzaSyATpBKPhD1nbjcXsW0cR-i6EzJTf8xkdpM";

            //"&markers=size:tiny%7color:red%7Clabel:S%7C37.5912657864989,127.02206239287148" + //�б�
            //"&markers=size:tiny%7color:red%7Clabel:S%7C37.556533,126.936731" + //ǲ��Ŀ
            //"&markers=color:green%7Cllabel:D%7C" + "37.566332,126.843170" + //�� ����
            //"&markers=color:blue%7Cllabel:D%7C" + "37.566427,126.842548" + //�� ����         

            WWW www = new WWW(url);
            yield return www;
            img.texture = www.texture;

            debugText.text = "\n\n���� ����� ��ǥ���� �Ÿ� : \n�� " + Closest() + "M" + "\n";

            //debugText.text += getUpdatedGPSstring(37.591175, 127.022247); // ����
            //debugText.text += getUpdatedGPSstring(37.591057, 127.021561); // ���վȳ���
            //debugText.text += getUpdatedGPSstring(37.591595, 127.022446); // ���ſ����
            //debugText.text += getUpdatedGPSstring(37.591972, 127.021332); // ���ջ�Ȳ��
            //debugText.text += getUpdatedGPSstring(37.591278, 127.020851); // �볪�� ��
            //debugText.text += getUpdatedGPSstring(37.590813, 127.021484); // ������ �׸�
            //debugText.text += getUpdatedGPSstring(37.591274, 127.020851); // ���ſ��� ���� �׸�
            //debugText.text += UpdateDistance(37.510284, 127.088417); // ��
            //debugText.text += UpdateDistance(37.57595, 126.8383); // ����Ĺ��� ��ó

            //img.SetNativeSize();

        }

        // Stop service if there is no need to query location updates continuously
        isUpdating = !isUpdating;
        Input.location.Stop();
    }


    public double Closest()
    {
        //double place1 = UpdateDistance(37.591175, 127.022247); // ����
        double place2 = UpdateDistance(37.591057, 127.021561); // ���վȳ���
        double place3 = UpdateDistance(37.591595, 127.022446); // ���ſ����
        double place4 = UpdateDistance(37.591972, 127.021332); // ���ջ�Ȳ��
        double place5 = UpdateDistance(37.591278, 127.020851); // �볪�� ��
        double place6 = UpdateDistance(37.590813, 127.021484); // ������ �׸�
        double place7 = UpdateDistance(37.591274, 127.020851); // ���ſ��� ���� �׸�
        double place1 = UpdateDistance(37.57595, 126.8383); // ����Ĺ��� ��ó

        double[] data = { place1, place2, place3, place4, place5, place6, place7 };

        double min = data[0];

        for (int i = 0; i < data.Length; i++)
        {
            //�ּڰ� ���ϱ�
            if (min > data[i])
            {
                min = data[i];
            }
        }
       
        if (min == place1) {HintName = "HintName1"; }

        if (min == place2) { HintName = "HintName2"; }

        if (min == place3) { HintName = "HintName3"; }

        if (min == place4) { HintName = "HintName4"; }

        if (min == place5) { HintName = "HintName5"; }

        if (min == place6) { HintName = "HintName6"; }

        if (min == place7) { HintName = "HintName7"; }


        return min;
    }

    double UpdateDistance(double TargetLatitude, double TargetLongtitude)
    {
        myGPSLocation = Input.location.lastData;

        MyLongtitude = Math.Round(myGPSLocation.longitude, 6);
        MyLatitude = Math.Round(myGPSLocation.latitude, 6);

        double DistanceToMeter;


        //�� ������ �Ÿ�
        DistanceToMeter = distance(MyLatitude, MyLongtitude, TargetLatitude, TargetLongtitude, DistUnit.meter);
        //DistanceToMeter = distance (37.507775, 127.039675, 37.507660, 127.039530, "meter"); // 20���� �̳� �Ÿ�üũ

        if (DistanceToMeter < 5)
        {// �ǹ��� ������ �� ȯ������ ��ҷ� ���� ������ �߻� �� �� ����.
            //��ó O
            frame.SetActive(true);
            HintBtn.SetActive(true);
        }
        else
        {
            //��ó X
            frame.SetActive(false);
            HintBtn.SetActive(false);
        }


        return DistanceToMeter;
    }

    /**
???? * �� �������� �Ÿ� ���
???? *
???? * @param lat1 ���� 1 ����
???? * @param lon1 ���� 1 �浵
???? * @param lat2 ���� 2 ����
???? * @param lon2 ���� 2 �浵
???? * @param unit �Ÿ� ǥ�����
???? * @return
???? */
    static double distance(double lat1, double lon1, double lat2, double lon2, DistUnit unit)
    {

        double theta = lon1 - lon2;
        double dist = Math.Sin(deg2rad(lat1)) * Math.Sin(deg2rad(lat2)) + Math.Cos(deg2rad(lat1)) * Math.Cos(deg2rad(lat2)) * Math.Cos(deg2rad(theta));

        dist = Math.Acos(dist);
        dist = rad2deg(dist);
        dist = dist * 60 * 1.1515;

        if (unit == DistUnit.kilometer)
        {
            dist = dist * 1.609344;
        }
        else if (unit == DistUnit.meter)
        {
            dist = dist * 1609.344;
        }

        return (dist);
    }

    // This function converts decimal degrees to radians
    static double deg2rad(double deg)
    {
        return (deg * Math.PI / 180.0);
    }

    // This function converts radians to decimal degrees
    static double rad2deg(double rad)
    {
        return (rad * 180 / Math.PI);
    }

}
enum DistUnit
{
    kilometer,
    meter
}