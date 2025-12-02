using UnityEngine;

public class UIManager : MonoBehaviour
{
    public GameObject popupPrefab; // 게임 오브젝트 변수 설정 -> 팝업 프리팹
    public Transform canvasTransform; // 위치 변수 설정
    public string TitleText;
    public string ContentText;

    public void OpenNoticePopup()
    {
        GameObject newPopup = Instantiate(popupPrefab, canvasTransform); // 생성한 팝업을 뉴 팝업으로 변수 선언
        Popup popupScript = newPopup.GetComponent<Popup>(); // 팝업 스크립트 변수

        popupScript.SetContent(this.TitleText, this.ContentText); // 팝업 내용 설정
    }
}
