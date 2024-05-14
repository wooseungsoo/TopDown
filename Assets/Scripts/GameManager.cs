using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public GameObject startUI; // 시작 UI 오브젝트
    public InputField nameInputField; // 이름 입력 필드
    public Text characterNameText; // 캐릭터 위에 표시될 이름 Text
    public GameObject character; // 캐릭터 오브젝트

    // 게임 시작 버튼이 눌렸을 때 호출될 메서드
    public void StartGame()
    {
        // 입력받은 이름을 캐릭터 이름 Text에 설정
        characterNameText.text = nameInputField.text;

        // 캐릭터 이름 Text의 위치를 캐릭터의 머리 위로 조정
        characterNameText.transform.position = Camera.main.WorldToScreenPoint(character.transform.position + new Vector3(0, 1, 0)); // 1은 캐릭터 머리 위의 오프셋, 필요에 따라 조정

        // 시작 UI 비활성화
        startUI.SetActive(false);
       
    }
}