/* < 플레이어 컨트롤러(PkayerController) > 
 * - 플레이어가 좌우 화살표 버튼을 눌렀을 때, 화살표 버튼이 눌린것을 감지하고, 플레이어를 움직이는 스크립트
 *      - 키가 눌렀는지 검출하기 위해서는 Input 클래스의 GetKwyDown 메서드를 사용함
 *      - 키를 누른 순간 : GetKeyDown()
 *      - 키를 누르고 있는 순간 : getKey()
 *      - 키를 누르다가 뗀 순간 : GetKeyUp()
 *      - 왼쪽 화살표 키를 눌렀을 때 -> GetKeyDown(KeyCode.LeftArrow)
 *      - 오른쪽 화살표 키를 눌렀을 때 -> GetKeyDown(KeyCode.RightArrow)
 *     + 플레이어를 현재 좌표에서 인수 값만큼 좌, 우로 이동시키는 기능 --> transform.Translate()
 */


using UnityEngine;

public class PlayerController : MonoBehaviour
{
    //변수 선언

    //실행 시 한번 수
    void Start()
    {
        //프레임 레이트를 60으로 고정, 디바이스 성능에 따른 실행 결과의 차이 없애
        Application.targetFrameRate = 60;
    }

    //매 프레임 마다 실행
    void Update()
    {
        //왼쪽 화살 키가 눌렸을때 -> GetKeyDown(KeyCode.LeftArrow)
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            // Translate 메서드 : 오브젝트를 현재 좌표에서 인수만큼 이동시키는 메서드
            // 값이 -3 이므로 왼쪽에서 '3' 만큼 움직인다
            transform.Translate(-3, 0, 0);
        }

        //오른쪽 화살표 키가 눌렸을때 -> GetKeyDown(KeyCode.RightArrow)
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            transform.Translate(3, 0, 0);
        }
    }
}
