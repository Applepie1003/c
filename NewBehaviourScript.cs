using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{

    void Start()
    { 
            Debug.Log("Hello unity!");

            //1. ����
            int level = 5;
            //int : ������ ������
            float strength = 15.5f;
            //float : ������ ������
            string playerName = "�հ���";
            //string: ���ڿ� ������
            bool isFullLevel = false;
            //bool ���� ������

            //2. �׷��� ����
            string[] monster = { "������", "�縷��", "�Ǹ�" };
            int exp = 1500;

            exp = 1500 + 320;
            exp = exp - 10;
            level = exp / 300;
            strength = level * 3.1f;

            Debug.Log("����� �� ����ġ��?");
            Debug.Log(exp);
            Debug.Log("����� ������?");
            Debug.Log(level);
            Debug.Log("����� ����?");
            Debug.Log(strength);

            //������ ������
            int nextexp = 300 - (exp % 300);
            Debug.Log("���� �������� ���� ����ġ��?");
            Debug.Log(nextexp);

            string title = "������";
            Debug.Log("����� �̸���?");
            Debug.Log(title + " " + playerName);

            int fullLevel = 99;
            isFullLevel = level == fullLevel;
            Debug.Log("���� �����Դϱ�?" + isFullLevel);

            bool isEndTutorial = level > 10;
            Debug.Log("Ʃ�丮���� ���� ����ΰ�?" + isEndTutorial);
            // >= �̻�, <= ����, > �ʰ�, < �̸�

            int health = 55;
            int mana = 25;
            //bool isBadCondition = health <= 50 && mana <= 20;
            // &&(and): �� ���� ��� true �ϋ��� true ���
            bool isBadCondition = health <= 50 || mana <= 20;
            // ||(or): �� �� �߿��� �ϳ��� true �̸� true ���

            Debug.Log("����� ���°� ���޴ϱ�?" + isBadCondition);

            string condition = isBadCondition ? "����" : "����";
            Debug.Log("����� ���°� ���޴ϱ�?" + condition);
            //? A: B: true �� �� A, false�� �� B ���

            //4.Ű����
            //int float string bool new
            //���������� ��� �� �� ����

            //5.���ǹ�
            //if: ������ true �� ��, ���� ����
            /* if(����) {
                ����
            } */
            if (condition == "����")
            {
                Debug.Log("�÷��̾� ���°� ���ڴ� �������� ����ϼ���.");
            }
            // else: ���� if�� ������� ������ ����
            else
            {
                Debug.Log("�÷��̾� ���°� �����ϴ�.");
            }

            //switch, case: ������ ���� ���� ���� ����




            switch (monster[1])
            {
                case "������":
                case "�縷��":
                    Debug.Log("���� ���� ����");
                    break;
                case "�Ǹ�":
                    Debug.Log("���� ���� ����");
                    break;
                case "��":
                    Debug.Log("���� ���� ����");
                    break;
                default:
                    Debug.Log("??? ���Ͱ� ����!");
                    break;

            }

            //6. �ݺ���

            /* while (����) {
                ����
            } */

            while (health > 0)
            {
                health--;
                if (health > 0)
                    Debug.Log("�� �������� �Ծ����ϴ�." + health);
                else
                    Debug.Log("����Ͽ����ϴ�.");
                if (health == 10)
                {
                    Debug.Log("�ص����� ����մϴ�.");
                    break;
                }

            }
            for (int count = 0; count < 10; count++)
            {
                Debug.Log("�ش�� ġ�� ��..." + health);
            }

            // �׷������� ���� : Length(�迭), Count(����Ʈ)
            for (int index = 0; index < monster.Length; index++)
            {
                Debug.Log("�� ������ �ִ� ���� : " + monster[index]);
            }
     }
    
}
