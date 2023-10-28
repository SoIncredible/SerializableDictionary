using UnityEngine;

namespace CheckBox
{
    public class TestArray : MonoBehaviour
    {
        public string[] options = { "选项1", "选项2", "选项3" };
        [SerializeField] private int[] m_testArr;
    }
}