using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ch12 : MonoBehaviour
{
    private void Awake()
    {
        Debug.Log($"플레이어 생성");
        Player player = new Player("Noname", 0);//id는 Noname, hp는 0으로 초기화
        Debug.Log($"이름: {player.ID}");
        Debug.Log($"HP: {player.GetCurrentHP()}");//플레이어 현재 HP 출력

        Debug.Log($"이름 및 HP 설정");
        player.ID = "이준호";
        player.SetCurrentHP(150);

        Debug.Log($"이름: {player.ID}");
        Debug.Log($"HP: {player.GetCurrentHP()}");

        //private 멤버 변수에 접근 불가. Error.
        /*
        player.currentHP = 100;
        Debug.Log($"HP: {player.currentHP}");
        */

        //currentHP의 Set, Get 메소드에 접근
        Debug.Log($"플레이어 HP 바꾸기");
        player.SetCurrentHP(100);//private 접근 지정자인 currentHP 수정하기 위한 방법
        Debug.Log($"HP: {player.GetCurrentHP()}");
    }
}

public class Entity
{
    public string ID;
    protected int currentHP;

    //ID 기본값 초기화
    private void Initialize()
    {
        ID = "Noname";
        currentHP = 0;
    }

    //닉네임 설정하는 메소드
    private void SetID(string id)
    {
        ID = id;
    }

    //현재 HP에 입력값만큼 HP 추가하는 메소드
    public void RecoveryHP(int hp)
    {
        currentHP += hp;
    }

    //HP 설정하는 메소드
    public void SetCurrentHP(int hp)
    {
        if (hp > 0)
        {
            currentHP = hp;
        }
    }

    //HP 출력하는 메소드
    public int GetCurrentHP()
    {
        return currentHP;
    }
}

public class Player : Entity
{
    public Player(string id, int hp)
    {
        ID = id;
        currentHP = hp;

        //private이기 때문에 사용 불가
        /*
        Initialize();
        */
    }
}