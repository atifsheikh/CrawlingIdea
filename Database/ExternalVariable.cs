using System;
using Starcounter;

namespace OneKey.Database
{
    public class ExternalVariable : Concept //E.g. a cookie or a token.
    {
        //VariableName and Type together can be used in crawling Sub-Level Variable creation
        public ExternalAction Action;
        public string VariableType; //Cookie / body token / url token
        public string Regex; //The regex used to set the VariableValue.
        public string VariableValue;
    }
}
