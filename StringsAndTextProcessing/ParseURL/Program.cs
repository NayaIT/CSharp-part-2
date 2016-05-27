/* ParseURL
Description
Write a program that parses an URL address given in the format: [protocol]://[server]/[resource] and extracts from it the [protocol], [server] and [resource] elements.

Input
On the only line you will receive an address

Output
Print the protocol, server and resource as shown below

Constraints
Time limit: 0.1s
 */

using System;

namespace ParseURL
{
    class Program
    {

        static void Main()
        {
            var url = Console.ReadLine().Trim();

            var protocol = ExtractProtocol(url);
            var server = ExtractServer(url);
            var resource = ExtractResource(url, server);

            Console.WriteLine("[protocol] = {0}", protocol);
            Console.WriteLine("[server] = {0}", server);
            Console.WriteLine("[resource] = {0}", resource);
        }

        static string ExtractResource(string url, string server)
        {
            int indexOfLastServerLetter = url.IndexOf(server);
            var resource = url.Substring(indexOfLastServerLetter + server.Length);
            return resource;
        }

        static string ExtractServer(string url)
        {
            int indexOfFirstDoubleSlash = url.IndexOf("//");
            int indexOfSecondSlash = url.IndexOf("/", indexOfFirstDoubleSlash + 2);
            var server = url.Substring(indexOfFirstDoubleSlash + 2, indexOfSecondSlash - indexOfFirstDoubleSlash - 2);
            return server;
        }

        static string ExtractProtocol(string url)
        {
            int indexOfColon = url.IndexOf(":");
            var protocol = url.Substring(0, indexOfColon);
            return protocol;
        }
    }
}
