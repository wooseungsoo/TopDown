using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem.XR;

public class CharacterAnimationController : AnimationController
{
    // Animator.StringToHash�� ���� Animator ���� ��ȯ�� Ȱ��Ǵ� �κп� ���� ����ȭ�� ������ �� �ֽ��ϴ�.
    // StringToHash�� IsWalking�̶�� ���ڿ��� �Ϲ��� �Լ��� �ؽ��Լ��� ���� Ư���� ������ ��ȯ�մϴ�.
    // �� �ñ��Ͻôٸ� C# GetHashCode�� �˻��غ�����!
    private static readonly int IsWalking = Animator.StringToHash("IsWalking");
    private static readonly int IsHit = Animator.StringToHash("IsHit");

    private static readonly int Attack = Animator.StringToHash("Attack");

    private readonly float magnituteThreshold = 0.5f;

    protected override void Awake()
    {
        base.Awake();
    }

    void Start()
    {
        // �����ϰų� ������ �� �ִϸ��̼��� ���� �����ϵ��� ����
       // controller.OnAttackEvent += Attacking;
        controller.OnMoveEvent += Move;
    }

    private void Move(Vector2 obj)
    {
        animator.SetBool(IsWalking, obj.magnitude > magnituteThreshold);
    }

    // OnAttackEvent�� Action<AttackSO>�̱� ������ Attacking�� AttackSO�� ������� �ʾƵ� �Ű������� ������ �־�� �մϴ�.
    // �̷� �� �Լ�(�޼ҵ�) �ñ״�ó�� ����ٶ�� �մϴ�.
    //private void Attacking(AttackSo obj)
    //{
    //    animator.SetTrigger(Attack);
    //}

    // ���� �ǰݺκ��� ������ �� �� ���̱� ������ �ϴ� �Ӵϴ�.
    private void Hit()
    {
        animator.SetBool(IsHit, true);
    }

    // ���� �ǰݺκ��� ������ �� �� ���̱� ������ �ϴ� �Ӵϴ�.
    private void InvincibilityEnd()
    {
        animator.SetBool(IsHit, false);
    }
}