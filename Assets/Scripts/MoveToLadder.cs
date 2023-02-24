using UnityEngine;

public class MoveToLadder : MonoBehaviour {

    [SerializeField]
    private Vector3[] points;
    [SerializeField]
    private Vector3[] movePoints;
    [SerializeField]
    private Vector3[] castlePoints;
    [SerializeField]
    private float speed = 3f;
    [SerializeField]
    private Transform _lockObjectInDialog;

    private int currentIndex;
    private bool startMoveLandBool;

    private void Start() {
        currentIndex = 0;
        this.transform.LookAt(points[4]);
        startMoveLandBool = false;
    }

    private void FixedUpdate() {
        if(startMoveLandBool == true) {
            MovePlayerToLand();
        }
    }

    public void StartMoveLand() {
        startMoveLandBool = true;
    }




    private void MovePlayerToLand() {
        var target = movePoints[currentIndex];

        if(this.transform.position != target) {
            this.transform.LookAt(target);
            this.transform.position = Vector3.MoveTowards(transform.position, target, speed * Time.deltaTime);

            if(currentIndex == movePoints.Length - 1) {
                this.transform.LookAt(_lockObjectInDialog);
            }

        } else {
            currentIndex++;
        }

        if(currentIndex != movePoints.Length - 1 && this.transform.position == target) {
            MovePlayerToLand();
        }
    }


    public void MovePlayer_1() {
            Debug.Log($"������ ����� = {points[0]}");
            this.gameObject.transform.position = points[0];
           
            Debug.Log($"������� ��������� = {this.gameObject.transform.position}");
    }

    public void MovePlayer_2() {
        Debug.Log($"������ ����� = {points[1]}");

        this.gameObject.transform.position = points[1];
        
       

        Debug.Log($"������� ��������� = {this.gameObject.transform.position}");
        
    }

    public void MovePlayer_3() {
        Debug.Log($"������ ����� = {points[2]}");

        this.gameObject.transform.position = points[2];
        
        Debug.Log($"������� ��������� = {this.gameObject.transform.position}");

    }

    public void MovePlayer_4() {
        Debug.Log($"������ ����� = {points[3]}");

        this.gameObject.transform.position = points[3];
       

        Debug.Log($"������� ��������� = {this.gameObject.transform.position}");

    }

    public void MovePlayer_5() {
        Debug.Log($"��������� ����� = {points[4]}");

        this.gameObject.transform.position = points[4];
        

        Debug.Log($"������� ��������� = {this.gameObject.transform.position}");

    }

}
