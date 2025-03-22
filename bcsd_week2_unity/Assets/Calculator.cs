using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Calculator : MonoBehaviour
{
    private void Awake()
    {
        int a = 2, b = 3;   //변수 생성
        //자리 바꾸기
        Debug.Log("자리 바꾸기(값에 의한 전달)");
        Debug.Log($"before a = {a}, b = {b}");
        Swap(a,b);  //자리 바꾸는 함수
        Debug.Log($"after a = {a}, b = {b}"); //a, b의 값은 바뀌지 않음. 바뀐 것처럼 보여주려면 새 변수를 생성해서 대입해야 함.

        //참조에 의한 전달
        Debug.Log("자리 바꾸기(참조에 의한 전달)");
        Debug.Log($"before a = {a}, b = {b}");
        Swap(ref a , ref b);    //자리 바꾸는 함수
        Debug.Log($"after a = {a}, b = {b}");
        Swap(ref a , ref b);    //복구

        //출력 전용 매개변수 out 사용법
        a = 5; b = 4;   //변수 초기화
        int result1 = 0, result2 = 0;   //결과 변수 생성
        Divide(a, b, out result1, out result2); //값 2개 출력(result1, result2)
        Debug.Log($"몫 = {result1}, 나머지 = {result2}");

        //메소드 오버로딩 구현
        Add(10,20);
        Add(1.4f, 2.3f);
    }

    public void Sum(params int[] nums)
    {
        int sum = 0;
        for(int i = 0; i < nums.Length; ++i)
        {
            sum += nums[i];
        }
        Debug.Log($"가변 길이 매개변수 합계: {sum}");
    }

    public void Divide(int num1, int num2, out int result1, out int result2)
    {
        result1 = num1 / num2;
        result2 = num1 % num2;
    }

    //값에 의한 전달
    public void Swap(int num1, int num2)
    {
        int temp = num1;
        num1 = num2;
        num2 = temp;
    }

    //참조에 의한 전달
    public void Swap(ref int num1, ref int num2)
    {
        int temp = num1;
        num1 = num2;
        num2 = temp;
    }
    
    //정수 더하기
    public void Add(int num1, int num2)
    {
        int result = num1 + num2;
        Debug.Log($"정수 더하기: {num1} + {num2} = {result}");
    }

    //float 더하기
    public void Add(float num1, float num2)
    {
        float result = num1 + num2;
        Debug.Log($"실수 더하기: {num1} + {num2} = {result}");
    }

    //정수 곱하기
    public void Multiple(int num1, int num2)
    {
        int result = num1 * num2;
        Debug.Log($"{num1} X {num2} = {result}");
    }

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
