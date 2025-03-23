using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClassPractice : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

public class GameController : MonoBehaviour
{
    public Player player01;
    public Enemy enemy01;

    private void Awake()
    {
        player01 = new Player();
        Debug.Log($"플레이어 {player01.ID} 생성됨");

        enemy01.AttackToTarget(player01); //플레이어 공격
        Debug.Log($"플레이어 남은 HP: {player01.currentHP}");
    }
}

public class Player : MonoBehaviour
{
    public string ID = "이준호";
    public int currentHP = 1000;

    public void TakeDamage(int damage)
    {
        if (currentHP > damage)
        {
            currentHP -= damage;
        }
    }
}

public class Enemy
{
    private Player player;

    public void AttackToTarget(Player target)
    {
        target.TakeDamage(100);
        Debug.Log($"{target.ID}가 {100}의 데미지 받음!");
    }
}