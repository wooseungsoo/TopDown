using UnityEngine;
using UnityEngine.UI;

public class DisplayName : MonoBehaviour
{
    public InputField nameInputField; // InputField를 할당할 변수
    public Text nameText; // Text 컴포넌트를 할당할 변수
    public Transform characterTransform; // 캐릭터의 Transform을 할당할 변수
    public Vector3 offset; // 이름을 캐릭터 위에 표시하기 위한 오프셋 값

    void Update()
    {
        // 캐릭터의 현재 위치에 오프셋을 더해 Text의 위치를 업데이트합니다.
        Vector3 namePosition = Camera.main.WorldToScreenPoint(characterTransform.position + offset);
        nameText.transform.position = namePosition;

        // InputField에서 입력받은 이름을 Text 컴포넌트에 설정합니다.
        nameText.text = nameInputField.text;
    }
}