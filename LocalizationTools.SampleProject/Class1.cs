namespace LocalizationTools.SampleProject
{
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;
    using LocalizationTools.Attributes;
    using LocalizationTools.SampleProject.Properties;

    public class Class1
    {
        public const string AppName = "asdffgf";

        [LocalizedDescription("Please enter a business name")]
        public string Business { get; set; } = string.Format(Resources.Class1_Business_this_is_my__0__text, AppName);


        [DescriptionL("Class1_MyProperty4_My_other_desription", typeof(Resources))]
        public string MyProperty4 { get; set; }


        [LocalizedDescription(nameof(Resources.Class1_MyProperty_One_more_string_7), typeof(Resources))]
        public string MyProperty { get; set; }

        [Display(Description = "Once again {AppName} some text")]
        public string MyProperty1 { get; set; }

        ////[LocalizedDescription("CityDescription", typeof(Resources))]
        ////public string City1 { get; set; }
    }
}
