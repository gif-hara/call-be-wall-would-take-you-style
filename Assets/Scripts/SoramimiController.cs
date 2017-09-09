using UnityEngine;

namespace HK.Soramimi
{
    public sealed class SoramimiController : MonoBehaviour
    {
        [SerializeField]
        private string text;
        
        [SerializeField]
        private Database database;

        void Start()
        {
            Debug.Log(Soramimi.Translate(this.text, this.database));
        }
    }
}
