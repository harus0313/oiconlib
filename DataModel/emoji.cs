using System.Text.Json;

namespace oiconlib.DataModel
{
    public class emoji
    {

        public class MetaData
        {
            public string FilePath { get; set; }
            public string ImageType { get; set; }
            public string ImageExt { get; set; }
            public string Name { get; set; }
            public string Keywords { get; set; }
            public string Group { get; set; }

        }


        public static void expJson()
        {
            List<MetaData> emojiList = new List<MetaData>();

            MetaData emoji = new MetaData();
            emoji.FilePath = "/icons/emoji/1st place medal/3D/1st_place_medal_3d.png";
            emoji.ImageType = "3d";
            emoji.ImageExt = "svg";
            emoji.Name = "1st place medal";
            emoji.Keywords = "1st place medal gold";
            emoji.Group = "Activities";

            emojiList.Add(emoji);

            emoji = new MetaData();
            emoji.FilePath = "/icons/emoji/1st place medal/3D/1st_place_medal_3d.png";
            emoji.ImageType = "3d";
            emoji.ImageExt = "svg";
            emoji.Name = "1st place medal";
            emoji.Keywords = "1st place medal gold";
            emoji.Group = "Activities";

            emojiList.Add(emoji);

            string jsonStr = JsonSerializer.Serialize(emojiList);
            Console.WriteLine(jsonStr);

        }

        public static void impJson()
        {

        }


    }

}
