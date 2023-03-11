namespace System.Text.Json.Converters.Common
{
    public sealed class StringifiedNumberArrayWithSemicolonSplitConverter : StringifiedNumberArrayWithSplitConverterBase
    {
        protected override string Separator
        {
            get { return ";";  }
        }
    }
}