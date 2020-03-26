 using System.Linq;

namespace P01_HarvestingFields
{
    using System;
    using System.Reflection;

    public class HarvestingFieldsTest
    {
        public static void Main()
        {
            var type = typeof(HarvestingFields);

            FieldInfo[] fields;
            string typeToPrint;
            while ((typeToPrint = Console.ReadLine()) != "HARVEST")
            {
                switch (typeToPrint)
                {
                    case "private":
                        fields = type.GetFields(BindingFlags.Instance | BindingFlags.NonPublic).Where(f => f.IsPrivate).ToArray();
                        break;
                    case "public":
                        fields = type.GetFields(BindingFlags.Instance | BindingFlags.Public).Where(f => f.IsPublic).ToArray();
                        break;
                    case "protected":
                        fields = type.GetFields(BindingFlags.Instance | BindingFlags.NonPublic).Where(f => f.IsFamily).ToArray();
                        break;
                    default:
                        fields = type.GetFields(BindingFlags.Instance | BindingFlags.NonPublic | BindingFlags.Public);
                        break;
                }

                PrintFields(fields);
            }
        }

        private static void PrintFields(FieldInfo[] fields)
        {
            string pattern = "{0} {1} {2}";
            string result = String.Empty;

            foreach (var field in fields)
            {
                string accessModifier = field.Attributes.ToString().ToLower();
                if (field.IsFamily)
                {
                    accessModifier = "protected";
                }

                result = String.Format(pattern, accessModifier, field.FieldType.Name, field.Name);

                Console.WriteLine(result);
            }
        }
    }
}
