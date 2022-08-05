using System.Collections;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Android;
using System;

public class GPS : MonoBehaviour
{
    public bool isUpdating;
    public RawImage img;
    public Text gpsOut;
    string url;
    public WaitForSeconds second;
    public Text debugText;

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
            
            "&markers=label:S|icon:https%3A%2F%2Fi.imgur.com%2F13M4rVZ.png%7C37.556182,126.937071"  + //�������ī�� //��׸�
            "&markers=label:S|icon:https%3A%2F%2Fi.imgur.com%2FQVT2pqX.png%7C37.556533,126.936731" + //ǲ��Ŀ //��
            "&key=AIzaSyATpBKPhD1nbjcXsW0cR-i6EzJTf8xkdpM";

            //"&markers=size:tiny%7color:red%7Clabel:S%7C37.5912657864989,127.02206239287148" + //�б�
            //"&markers=size:tiny%7color:red%7Clabel:S%7C37.556533,126.936731" + //ǲ��Ŀ
            //"&markers=color:green%7Cllabel:D%7C" + "37.566332,126.843170" + //�� ����
            //"&markers=color:blue%7Cllabel:D%7C" + "37.566427,126.842548" + //�� ����



            WWW www = new WWW(url);
            yield return www;
            img.texture = www.texture;
            debugText.text = getUpdatedGPSstring(37.556182, 126.937071); //���ٵ�
            debugText.text += getUpdatedGPSstring(37.556533, 126.93673); // �������ī��
            //img.SetNativeSize();

        }

        // Stop service if there is no need to query location updates continuously
        isUpdating = !isUpdating;
        Input.location.Stop();
    }
    string getUpdatedGPSstring(double TargetLatitude,double TargetLongtitude)
    {
        myGPSLocation = Input.location.lastData;

        MyLongtitude = Math.Round(myGPSLocation.longitude, 6);
        MyLatitude = Math.Round(myGPSLocation.latitude, 6);

        double DistanceToMeter;
        string storeRange;
      
        //�� ������ �Ÿ�
        DistanceToMeter = distance(MyLatitude, MyLongtitude, TargetLatitude, TargetLongtitude, DistUnit.meter);
        //DistanceToMeter = distance (37.507775, 127.039675, 37.507660, 127.039530, "meter"); // 20���� �̳� �Ÿ�üũ

        if (DistanceToMeter < 45)
        {// �ǹ��� ������ �� ȯ������ ��ҷ� ���� ������ �߻� �� �� ����.
            storeRange = "��ó O";
        }
        else
        {
            storeRange = "��ó X";
        }

        return "\n������ġ :\n" +
        "�浵 - " + Math.Round(MyLatitude, 6) + "\n" +
        "���� - " + Math.Round(MyLongtitude, 6) +

        "\n\n" + "��ǥ��ġ : " + LocationName + "\n" +
        "�浵 - " + TargetLatitude + "\n" +
        "���� - " + TargetLongtitude +

        "\n\n��ǥ���ǰŸ� : \n�� " + DistanceToMeter + "M" + "\n" +
        "-------------\n\n" +

        storeRange;
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