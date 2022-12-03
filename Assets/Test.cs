using UnityEngine;

namespace MethodCallOrder
{
    [DefaultExecutionOrder(100)]
    [RequireComponent(typeof(BoxCollider))]
    public class Test : MonoBehaviour
    {
        private void OnEnable()
        {
            
        }

        private void Awake()
        {

        }

        private void Start()
        {
            
        }

        private void FixedUpdate()
        {
            Debug.Log(Time.deltaTime);
            Debug.Log(Time.fixedDeltaTime); // Fixed TimeStep 0.02 TimeScale 1
        }
        private void Update()
        {
            Debug.Log("второй в  очереди");    
        }

        private  void LateUpdate()
        {
            Debug.Log("третий в  очереди");
        }

        private void OnDisable()
        {
            
        }

        private void OnDestroy()
        {
            
        }
    }

    [DefaultExecutionOrder(50)] //ѕринудительное изменение очередности вызова
    public class Test2 : MonoBehaviour
    {
        private void Update()
        {
            Debug.Log("");
        }
    }

}
