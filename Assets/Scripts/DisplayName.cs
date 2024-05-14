using UnityEngine;
using UnityEngine.UI;

public class DisplayName : MonoBehaviour
{
    public InputField nameInputField; // InputField�� �Ҵ��� ����
    public Text nameText; // Text ������Ʈ�� �Ҵ��� ����
    public Transform characterTransform; // ĳ������ Transform�� �Ҵ��� ����
    public Vector3 offset; // �̸��� ĳ���� ���� ǥ���ϱ� ���� ������ ��

    void Update()
    {
        // ĳ������ ���� ��ġ�� �������� ���� Text�� ��ġ�� ������Ʈ�մϴ�.
        Vector3 namePosition = Camera.main.WorldToScreenPoint(characterTransform.position + offset);
        nameText.transform.position = namePosition;

        // InputField���� �Է¹��� �̸��� Text ������Ʈ�� �����մϴ�.
        nameText.text = nameInputField.text;
    }
}