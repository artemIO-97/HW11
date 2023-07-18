using HW11;
using System.IO;
using System.Runtime.Serialization.Json;
using System.Text.Json;
using System.Xml.Serialization;

var path = "Superherosquad—.json";
using (var file = new StreamReader(path))
{
    var text = file.ReadToEnd();
    var squad = JsonSerializer.Deserialize<SquadBase>(text);

    using (var xmlFile = new FileStream("path.xml",FileMode.OpenOrCreate))
    {
        new XmlSerializer(typeof(SquadBase)).Serialize(xmlFile, squad);
        
    }

}







