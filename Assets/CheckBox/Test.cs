using UnityEngine;

namespace CheckBox
{
    public class Test : MonoBehaviour
    {
        private static string[] options = { "1", "2", "3" };
        [StringInList("1", "2", "3")] public string AA;
    }
}