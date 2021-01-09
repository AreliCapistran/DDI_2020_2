using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

namespace IBM.Watsson.Examples
{

    public class VoiceCommandProcessor : MonoBehaviour
    {
        static protected VoiceCommandProcessor s_VoiceInstance;
        static public VoiceCommandProcessor Instance { get { return s_VoiceInstance; } }

        public delegate void OnVoiceCommand(string action);
        public OnVoiceCommand onVoiceCommand;

        public List<string> actions;
        public List<string> specialActions;

        public List<GameObject> spawningPrefabs;

        public Text datat, d1, d2, d3, d4, d5;

        public GameObject other, other2, other3, other4, other5;
        public int cont = 0;


        void Awake()
        {
            s_VoiceInstance = this;
        }

        public void Create(string transcript)
        {
            string[] words = transcript.Split(' ');
            foreach (var word in words)
            {
                if (actions.Contains(word.ToLower()))
                {
                    if (onVoiceCommand != null)
                    {
                        onVoiceCommand.Invoke(word.ToLower());
                    }
                    return;
                }
            }

            foreach (var word in words)
            {
                if (specialActions.Contains(word.ToLower()))
                {
                    if (word == "get")
                    {
                        SpawnObject(words);
                    }
                    else if (word == "information")
                    {
                        data();
                    }
                    else if (word == "police")
                    {
                        fin();
                    }
                    else if (word == "exit")
                    {
                        quit();
                    }
                    else if (word == "laptop" && other.gameObject.CompareTag("Laptop"))
                    {
                        lap();
                    }
                    else if (word == "knife" && other.gameObject.CompareTag("Knife"))
                    {
                        knife();
                    }
                    else if (word == "okey" && other.gameObject.CompareTag("Key"))
                    {
                        key();
                    }
                    else if (word == "shackles" && other.gameObject.CompareTag("Sha"))
                    {
                        sha();
                    }
                    else if (word == "axe" && other.gameObject.CompareTag("Axe"))
                    {
                        axe();
                    }
                }
                break;
            }
        }

        void SpawnObject(string[] words)
        {
            foreach (var word in words)
            {
                foreach (var prefab in spawningPrefabs)
                {
                    if (prefab.name == word.ToLower())
                    {
                        Instantiate(prefab, new Vector3(85f, 1.6f, 4.42f), Quaternion.identity);
                    }
                    break;
                }
            }
        }

        void data()
        {
            datat.text = "Si encuentras el cuerpo gripa ¡HELP ME!";
        }

        
        void fin()
        {
            datat.text = "¡Encontraste el cuerpo!, ya viene la policia";
            AudioSource audioSource;
            audioSource = GetComponent<AudioSource>();
            audioSource.Play();
            Application.Quit();
        }

        void quit()
        {
            datat.text = "Saliendo...";
            Application.Quit();
        }

        void lap()
        {
            cont = cont + 1;
            Destroy(other);
            d1.text = "Laptop: 1";
        }
        void knife()
        {
            cont = cont + 1;
            Destroy(other2);
            d2.text = "Knife: 1";
        }
        void key()
        {
            cont = cont + 1;
            Destroy(other3);
            d3.text = "Key: 1";
        }
        void sha()
        {
            cont = cont + 1;
            Destroy(other4);
            d4.text = "Shackles: 1";
        }
        void axe()
        {
            cont = cont + 1;
            Destroy(other5);
            d5.text = "Axe: 1";
        }

    }
}
