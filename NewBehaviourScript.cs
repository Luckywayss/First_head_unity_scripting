using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    int health = 100;

    void Start()
    {
        Debug.Log("Hello Unity!");

        //1.변수
        int level = 5;
        float intelligence = 15.5f;
        string playerName = "나법사";
        bool isFullLevel = false;

        /*Debug.Log("용사의 이름은?");
        Debug.Log(playerName);
        Debug.Log("용사의 레벨은?");
        Debug.Log(level);
        Debug.Log("용사의 지능은?");
        Debug.Log(intelligence);
        Debug.Log("용사는 만렙인가?");
        Debug.Log(isFullLevel);*/

        //2. 그룹형 변수
        string[] monsters = { "하피", "서큐버스", "안다리엘" };

        /*Debug.Log("맵에 존재하는 몬스터");
        Debug.Log(monsters[0]);
        Debug.Log(monsters[1]);
        Debug.Log(monsters[2]);*/

        int[] monstersLevel = new int[3];
        monstersLevel[0] = 3;
        monstersLevel[1] = 12;
        monstersLevel[2] = 20;

        /*Debug.Log("맵에 존재하는 몬스터의 레벨");
        Debug.Log(monstersLevel[0]);
        Debug.Log(monstersLevel[1]);
        Debug.Log(monstersLevel[2]);*/

        List<string> items = new List<string>();
        items.Add("생명물약30");
        items.Add("마나물약30");

        /*Debug.Log("가지고 있는 아이템");
        Debug.Log(items[0]);
        Debug.Log(items[1]);*/

        //3. 연산자
        int exp = 1500;

        exp = 1500 + 320;
        exp = exp - 10;
        level = exp / 300;
        intelligence = level * 3.1f;

        /*Debug.Log("용사의 총 경험치는?");
        Debug.Log(exp);
        Debug.Log("용사의 레벨은?");
        Debug.Log(level);
        Debug.Log("용사의 힘은?");
        Debug.Log(intelligence);*/

        int nextExp = 300 - (exp % 300);
        /*Debug.Log("다음 레벨까지 남은 경험치는?");
        Debug.Log(nextExp);*/
        
        int health = 30;
        int mana = 25;
        bool isBadCondition = health <= 50 || mana <= 20;

        string condition = isBadCondition ? "나쁨" : "좋음";
        /*Debug.Log("용사의 상태가 나쁩니까?" + condition);*/
        
        //4. 키워드

        //5. 조건문

        //6. 반복문
        foreach(string Devil in monsters)
        {
            //Debug.Log("이 지역에 있는 몬스터 : " + Devil);
        }

        //7. 함수
        //heal();

        /*for (int index = 0; index < monsters.Length; index++)
        {
            Debug.Log("용사는 " + monsters[index] + "에게 " +
                 Battle(monstersLevel[index]));
        }*/

        void heal()
        {
            health += 10;
            Debug.Log("힐을 받았습니다. " + health);
        }

        string Battle(int monstersLevel)
        {
            string result;
            if (level >= monstersLevel)
                result = "이겼습니다.";
            else
                result = "졌습니다.";
            return result;
        }

        //8. 클래스
        Player player = new Player();
        player.id = 0;
        player.name = "나전사";
        player.title = "현명한";
        player.strength = 2.4f  ;
        player.weapon = "목검";
        Debug.Log(player.Talk());
        Debug.Log(player.HasWeapon());

        player.LevelUp();
        Debug.Log(player.name + "의 레벨은 " + player.level + " 입니다.");
        Debug.Log(player.move());
    }
}
