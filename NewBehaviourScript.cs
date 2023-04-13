using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    int health = 100;

    void Start()
    {
        Debug.Log("Hello Unity!");

        //1.����
        int level = 5;
        float intelligence = 15.5f;
        string playerName = "������";
        bool isFullLevel = false;

        /*Debug.Log("����� �̸���?");
        Debug.Log(playerName);
        Debug.Log("����� ������?");
        Debug.Log(level);
        Debug.Log("����� ������?");
        Debug.Log(intelligence);
        Debug.Log("���� �����ΰ�?");
        Debug.Log(isFullLevel);*/

        //2. �׷��� ����
        string[] monsters = { "����", "��ť����", "�ȴٸ���" };

        /*Debug.Log("�ʿ� �����ϴ� ����");
        Debug.Log(monsters[0]);
        Debug.Log(monsters[1]);
        Debug.Log(monsters[2]);*/

        int[] monstersLevel = new int[3];
        monstersLevel[0] = 3;
        monstersLevel[1] = 12;
        monstersLevel[2] = 20;

        /*Debug.Log("�ʿ� �����ϴ� ������ ����");
        Debug.Log(monstersLevel[0]);
        Debug.Log(monstersLevel[1]);
        Debug.Log(monstersLevel[2]);*/

        List<string> items = new List<string>();
        items.Add("������30");
        items.Add("��������30");

        /*Debug.Log("������ �ִ� ������");
        Debug.Log(items[0]);
        Debug.Log(items[1]);*/

        //3. ������
        int exp = 1500;

        exp = 1500 + 320;
        exp = exp - 10;
        level = exp / 300;
        intelligence = level * 3.1f;

        /*Debug.Log("����� �� ����ġ��?");
        Debug.Log(exp);
        Debug.Log("����� ������?");
        Debug.Log(level);
        Debug.Log("����� ����?");
        Debug.Log(intelligence);*/

        int nextExp = 300 - (exp % 300);
        /*Debug.Log("���� �������� ���� ����ġ��?");
        Debug.Log(nextExp);*/
        
        int health = 30;
        int mana = 25;
        bool isBadCondition = health <= 50 || mana <= 20;

        string condition = isBadCondition ? "����" : "����";
        /*Debug.Log("����� ���°� ���޴ϱ�?" + condition);*/
        
        //4. Ű����

        //5. ���ǹ�

        //6. �ݺ���
        foreach(string Devil in monsters)
        {
            //Debug.Log("�� ������ �ִ� ���� : " + Devil);
        }

        //7. �Լ�
        //heal();

        /*for (int index = 0; index < monsters.Length; index++)
        {
            Debug.Log("���� " + monsters[index] + "���� " +
                 Battle(monstersLevel[index]));
        }*/

        void heal()
        {
            health += 10;
            Debug.Log("���� �޾ҽ��ϴ�. " + health);
        }

        string Battle(int monstersLevel)
        {
            string result;
            if (level >= monstersLevel)
                result = "�̰���ϴ�.";
            else
                result = "�����ϴ�.";
            return result;
        }

        //8. Ŭ����
        Player player = new Player();
        player.id = 0;
        player.name = "������";
        player.title = "������";
        player.strength = 2.4f  ;
        player.weapon = "���";
        Debug.Log(player.Talk());
        Debug.Log(player.HasWeapon());

        player.LevelUp();
        Debug.Log(player.name + "�� ������ " + player.level + " �Դϴ�.");
        Debug.Log(player.move());
    }
}
