using UnityEngine;

public class XBotDanceControl : MonoBehaviour
{
    private Animator anim;

    void Start()
    {
        // Lấy Animator gắn trên GameObject hiện tại
        anim = GetComponent<Animator>();

        // Kiểm tra kết nối Animator
        if (anim == null)
        {
            Debug.LogError("❌ Không tìm thấy Animator trên X Bot! Hãy chắc rằng script này gắn vào cùng GameObject có Animator component.");
        }
        else
        {
            Debug.Log("✅ Animator đã kết nối: " + anim.runtimeAnimatorController.name);
        }
    }

    void Update()
    {
        // Khi nhấn phím Space
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (anim != null)
            {
                Debug.Log("🎵 SPACE được nhấn → Trigger Dance()");
                anim.SetTrigger("Dance");
            }
        }
    }
}
