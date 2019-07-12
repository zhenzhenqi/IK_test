using UnityEngine;

namespace DitzelGames.FastIK
{
    public class SampleSinMover : MonoBehaviour
    {
//        public Vector3 Dir;
//        public Vector3 Start;
//
		public float r = 10;

		float theta;
		float phi;

        private void Awake()
        {
//            Start = transform.position;
			theta = Random.Range(0, 100);
			phi = Random.Range(0, 100);
        }

//        void Update()
//        {
//            //just move the object from a to b and back
//            // transform.position = Start + Dir * Mathf.Sin(Time.timeSinceLevelLoad);
//            Vector3 pos = transform.position;
//            pos += new Vector3(Mathf.Sin(Time.time/10),0,0);
//            transform.position = pos;
//        }
		void Update()
		{

			Vector3 pos = new Vector3();
			pos.x = r * Mathf.Sin(phi) * Mathf.Cos(theta);
			pos.y = r * Mathf.Sin(phi) * Mathf.Sin(theta);
			pos.z = r * Mathf.Cos(phi);

			transform.position = pos;


			theta += 0.01f;
			phi += 0.01f;
		}
    }
}
