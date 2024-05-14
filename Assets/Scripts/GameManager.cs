using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public GameObject startUI; // ���� UI ������Ʈ
    public InputField nameInputField; // �̸� �Է� �ʵ�
    public Text characterNameText; // ĳ���� ���� ǥ�õ� �̸� Text
    public GameObject character; // ĳ���� ������Ʈ

    // ���� ���� ��ư�� ������ �� ȣ��� �޼���
    public void StartGame()
    {
        // �Է¹��� �̸��� ĳ���� �̸� Text�� ����
        characterNameText.text = nameInputField.text;

        // ĳ���� �̸� Text�� ��ġ�� ĳ������ �Ӹ� ���� ����
        characterNameText.transform.position = Camera.main.WorldToScreenPoint(character.transform.position + new Vector3(0, 1, 0)); // 1�� ĳ���� �Ӹ� ���� ������, �ʿ信 ���� ����

        // ���� UI ��Ȱ��ȭ
        startUI.SetActive(false);
       
    }
}