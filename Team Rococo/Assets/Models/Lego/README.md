
Lego_T.fbx: 메쉬와 뼈로 구성된 기본 레고 T포즈 모델

Lego_Walk.fbx: 레고의 걷는 모션.
Lego_Idle.fbx: 레고의 정지 모션.
Lego_Attack.fbx: 레고의 공격 모션. 머리가 180도 회전한다.
Lego_Attack_NoHeadRotation.fbx: 레고의 공격 모션. 머리가 회전하지 않는다.

Lego_Transformation.fbx: 레고의 머리가 돌아가는 모션. Animator의 Idle이 적용된 상황에서 Parameters의 isTransfor를 체크함으로써 변신 할 수 있다. 체크 해제 시 원상복귀
Lego_Prepare_Attack.fbx: 오른팔의 칼을 드는 모션. Transformation과 Walk가 적용된 상태에서 isPrepareAttack 파라미터를 체크함으로써 추격 모션으로 사용 가능하다. 체크 해제 시 원상복귀

RightArmMask.mask: Walk와 Prepare_Attack을 동시에 적용하기 위해 Lego의 오른팔에 씌운 마스크. Animator의 Attack Layer에 적용되어 있다.

Lego_Camera.fbx: Lego의 카메라 패닉 애니메이션. 대기 상태인 Ready와 연출 모션인 Direction으로 구성되어 있다. 카메라가 너무 가까워 Lego_Camera -> lego -> knife를 담지 못하는 문제를 해결하기 위해 knife -> Skinned Mesh Renderer -> Update When Offscreen을 체크해 두었다.