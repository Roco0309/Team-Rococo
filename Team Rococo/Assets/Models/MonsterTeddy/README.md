특이 사항: MT = Monster Teddy의 줄임말로, 새로운 모델을 만드는 과정에서 이름 중복을 피하기 위해 이렇게 작명하였다.

MT_T.fbx: 메쉬와 뼈로 구성된 기본 T포즈 모델

MT_Idle.fbx: 기본 Idle 모션
MT_Walk1_Basic.fbx: 하체만 움직이며 걷는 심플한 모션
MT_Walk2_Aggressive.fbx: 좀 더 역동적으로 걷는 모션으로, 위 MT_Walk1_Basic.fbx와 둘 중 적절한 모션을 채택하면 된다.
MT_Attack.fbx: 공격 모션

MT_Camera.fbx: 카메라 연출 fbx파일. 기존 애니메이션 클립과 달리 메쉬도 통째로 들어있으며, 0-1프레임의 'Ready'모션과 전체 프레임의 'Direction' 모션으로 이루어져 있다. Ready는 카메라 재생 전 대기 상태이고, Direction은 플레이어가 MT와 처음 접촉했을 때 재생되는 패닉 모션이다.