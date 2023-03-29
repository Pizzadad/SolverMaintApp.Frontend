using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1
{
    public static class JsonToTreeView
    {
        public static void JsonToTree(this TreeView treeView, string json, string group_name)
        {
            if (string.IsNullOrWhiteSpace(json))
            {
                return;
            }

            var token = JToken.Parse(json).Type;

            switch (token.ToString())
            {
                case "Array":

                    var objJArray = JArray.Parse(json);
                    AddArrayNodes(objJArray, group_name, treeView.Nodes);

                    break;
                case "Object":

                    var objJson = JObject.Parse(json);
                    AddObjectNodes(objJson, group_name, treeView.Nodes);

                    break;
            }
        }
        public static void AddObjectNodes(JObject obj, string name, TreeNodeCollection parent, string imgNode = "")
        {
            var propertyTest = obj.ToObject<Dictionary<string, object>>();

            var imgDesc = imgNode == "" ? propertyTest["description"].ToString() : imgNode;

            var node = SelectPropertiesNode(propertyTest["name"].ToString(), imgDesc);
            parent.Add(node);

            var ttt = obj.Properties();

            foreach (var property in obj.Properties())
            {
                if (property.Value.Type.ToString() == "Array")
                {
                    AddTokenNodes(property.Value, property.Name, node.Nodes, imgDesc);
                }
            }
        }

        private static void AddArrayNodes(JArray array, string name, TreeNodeCollection parent, string imgNode = "")
        {
            var node = SelectPropertiesNode(name, imgNode);
            parent.Add(node);

            for (var i = 0; i < array.Count; i++)
            {
                AddTokenNodes(array[i], $"[{i}]", node.Nodes, imgNode);
            }
        }

        private static void AddTokenNodes(JToken token, string name, TreeNodeCollection parent, string imgNode = "")
        {
            switch (token)
            {
                case JValue _:
                    var nodeChild = SelectPropertiesNode($"{((JValue)token).Value}", imgNode);
                    parent.Add(nodeChild);                  
                    break;
                case JArray _:
                    AddArrayNodes((JArray)token, name, parent, imgNode);
                    break;
                case JObject _:
                    AddObjectNodes((JObject)token, name, parent, imgNode);
                    break;
            }
        }


        public static void JsonToTreeWithImage(this TreeView treeView,ImageList imageList,  string json, string group_name)
        {
            if (string.IsNullOrWhiteSpace(json))
            {
                return;
            }

            treeView.ImageList = imageList;

            var token = JToken.Parse(json).Type;

            switch (token.ToString())
            {
                case "Array":

                    var objJArray = JArray.Parse(json);
                    AddArrayNodes(objJArray, group_name, treeView.Nodes);

                    break;
                case "Object":

                    var objJson = JObject.Parse(json);
                    AddObjectNodes(objJson, group_name, treeView.Nodes);

                    break;
            }
        }

        private static TreeNode SelectPropertiesNode (string name, string category)
        {
            var node = new TreeNode(name);

            switch (category)
            {
                case "Capital":
                    node.ImageKey = "img1.jpg";
                    node.SelectedImageKey = "img1.jpg";
                    break;
                case "Norte":
                    node.ImageKey = "img2.jpg";
                    node.SelectedImageKey = "img2.jpg";
                    break;
                case "MuyNorte":
                    node.ImageKey = "2c3o68.jpg";
                    node.SelectedImageKey = "2c3o68.jpg";
                    break;
                default:
                    node.ImageKey = "002.png";
                    node.SelectedImageKey = "002.png";
                    break;
            }

            return node;
        }
    }

}
