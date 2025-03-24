using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CH11_1 : MonoBehaviour
{
    public Player player01;
    public Player player02;

    private void Awake()
    {
        player01 = new Player();
        player01.TakeDamage(100);
        Debug.Log($"{player01.ID}가 데미지 입음(현재 체력 {player01.currentHP})");
        player01.SetID("New");
    }
}

public class Player
{
    public string ID = "이준호";
    public int currentHP = 1000;

    public void TakeDamage(int damage)
    {
        if(currentHP > damage)
        {
            currentHP -= damage;
        }
    }

    public string SetID(string ID)
    {
        Debug.Log($"ID: 설정할 아이디: {ID}");
        Debug.Log($"ID: 이 클래스의 아이디: {this.ID}");
        return ID;
    }
}

public class Enemy
{
    private Player player;
    public void AttackToTarget(Player target)
    {
        target.TakeDamage(100);
    }
}