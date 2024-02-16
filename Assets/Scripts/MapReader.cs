using System;
using System.Collections;
using System.Collections.Generic;
using System.Xml;
using UnityEngine;

namespace Damagree.WorldGenerator {
    public class MapReader : MonoBehaviour {

        [Tooltip("The resource file that contains the OSM map data")]
        public string resourceFilel;

        private void Start() {
            // Load the map data from the resource file
            TextAsset mapData = Resources.Load<TextAsset>(resourceFilel);
            if (mapData == null) {
                Debug.LogError("Map data not found");
                return;
            }

            XmlDocument doc = new XmlDocument();
            doc.LoadXml(mapData.text);

            //
            SetBounds(doc.SelectNodes("/osm/bounds"));
            GetNodes(doc.SelectNodes("/osm/node"));
            GetWays(doc.SelectNodes("/osm/way"));
        }

        void GetWays(XmlNodeList xmlNodeList) {
            
        }

        void GetNodes(XmlNodeList xmlNodeList) {

        }

        void SetBounds(XmlNodeList xmlNodeList) {

        }
    }
}