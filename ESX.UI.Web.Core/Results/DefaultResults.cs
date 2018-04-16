namespace ESX.UI.Web.Core.Results
{
    public class DefaultResults
    {
        public string[] Erros { get; set; }

        public bool Success { get; set; }
    }

    public class DefaultResults<TResult> : DefaultResults
    {
        public TResult Result { get; set; }
    }
}
