using System;
using Starcounter;
using System.Collections;
using OneKey.Server;
using OneKey.Crawler;
using System.Threading.Tasks;
using OneKey.Server.Partials;
using OneKey.Database;
//using PolyjuiceNamespace;
using OneKey.Server.Handlers;


namespace OneKey
{
    public class Program
    {
        static void Main()
        {
            FeatureHooks.Init();
            InitHooks.Init();
            DemoHooks.Init();
            DatabaseIndexes.CreateIndexes();
        }
    }
}