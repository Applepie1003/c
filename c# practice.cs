using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    void start ()
    {
        Debug.Log("Hello unity!");
        
        //1. 변수
        int level = 5;
        //int : 정수형 데이터
        float strength = 15.5f;
        //float : 숫자형 데이터
        string playerName = "왕감자";
        //string: 문자열 데이터
        bool isFullLevel = false;
        //bool 논리형 데이터
        
         //2. 그룹형 변수
        string[] monster = { "슬라임", "사막뱀", "악마"};
        int exp = 1500;
         
        exp = 1500 + 320;
        exp = exp - 10;
        level = exp / 300;
        strength = level * 3.1f;
        
        Debug.Log("용사의 총 경험치는?");
        Debug.Log(exp);
        Debug.Log("용사의 레벨은?");
        Debug.Log(level);
        Debug.Log("용사의 힘은?");
        Debug.Log(strength);
        
        //나머지 연산자
        int nextexp = 300 - (exp % 300);
        Debug.Log("다음 레벨까지 남은 경험치는?");
        Debug.Log(nextexp);
        
        string title = "전설의";
        Debug.Log("용사의 이름은?");
        Debug.Log(title + " " + playerName);
        
        int fullLevel = 99;
        isFullLevel = level == fullLevel;
        Debug.Log("용사는 만렙입니까?" + isFullLevel);
        
        bool isEndTutorial = level > 10;
        Debug.Log("튜토리얼이 끝난 용사인가?" + isEndTutorial);
        // >= 이상, <= 이하, > 초과, < 미만
        
        int health = 55;
        int mana = 25;
        //bool isBadCondition = health <= 50 && mana <= 20;
        // &&(and): 두 값이 모두 true 일떄만 true 출력
        bool isBadCondition = health <= 50 || mana <= 20;
        // ||(or): 두 값 중에서 하나만 true 이면 true 출력
        
        Debug.Log("용사의 상태가 나쁩니까?" + isBadCondition);
        
        string condition = isBadCondition ? "나쁨" : "좋음";
        Debug.Log("용사의 상태가 나쁩니까?" + condition);
        //? A: B: true 일 때 A, false일 때 B 출력
        
        //4.키워드
        //int float string bool new
        //변수명으로 사용 할 수 없다
        
        //5.조건문
        //if: 조건이 true 일 때, 로직 실행
        /* if(조건) {
            로직
        } */
        if (condition == "나쁨") {
                Debug.Log("플레이어 상태가 나쁘니 아이템을 사용하세요.");
        }
        // else: 앞의 if가 실행되지 않으면 실행
        else {
            Debug.Log("플레이어 상태가 좋습니다.");
        }

        //switch, case: 변수의 값에 따라 로직 실행
        
        
        
    
        switch (monster[1]) {
                case "슬라임":
                case "사막뱀":
                    Debug.Log("소형 몬스터 출현");
                    break;
                case "악마":
                    Debug.Log("중형 몬스터 출현");
                    break;
                case "골렘":
                    Debug.Log("대형 몬스터 출현");
                    break;
                default:
                    Debug.Log("??? 몬스터가 출현!");
                    break;
                    
        }
        
        //6. 반복문
        
        /* while (조건) {
            로직
        } */
        
        while(health > 0) {
            health--;
            if(health > 0)
                Debug.Log("독 데미지를 입었습니다. " + health);
            else
                Debug.Log("사망하여습니다");
            if (health ==10) {
                Debug.Log("해독제를 사용합니다.");
                break;
            }
            
        }
    }

}

