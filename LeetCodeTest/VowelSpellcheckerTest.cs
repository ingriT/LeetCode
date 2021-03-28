using LeetCode;
using System;
using System.Collections.Generic;
using Xunit;

namespace LeetCodeTest
{
    public class VowelSpellcheckerTest
    {
        //["paa","kzp","","hbu","","","","auc","gsi","","","hua","","","bfg","gip","bvu","okq","ata","","nej","awz","zys","","","","","","","","iik","","","","orx","","rqc","","","awj","","qla","","","","dzw","tko","","","uqm","","ztg","bgu","","tre","","","","","ops","","uvw","","","","","uzw","gwh","","","","ixc","ckd","","knm","eys","","","emv","epe","zuo","","hvx","mnb","","","ozl","","shj","omd","","","","dfn","bel","","","nqm","","","asd","udc","","xyq","","","shj","","aiy","","gee","lij","","mpo","hwe","khc","","","ust","usr","dzw","","","bhl","","zuo","xxr","ops","cxs","ckd","noi","fof","orx","","","","ous","","obz","","","uob","fjp","","zhf","foa","","","","vzv","","","uaq","xxr","","","zhd","","","rmb","","","neb","","zph","zcl","paa","","","","","miq","kbc","fxa","nsa","lnh","khy","","shj","","mdm","","gee","","","rqc","","","tvi","","yir","vgi","hua","lws","","dvf","","miq","","","","","","","","","","","uae","mbx","","","","mzz","dny","","paa","","","","","uae","moz","uae","lws","kbc","","","","wvk","opn","","","cga","","","iiw","vgx","mho","","uuh","","","","","","vck","onq","","","uqm","yoz","vus","","uob","zre","","","","","qtu","","","","","awz","zuo","jek","vtq","bvu","zqi","","ljy","","","","wus","","","qbm","","neb","","lsp","qug","pdd","","cmo","ngl","ikg","","qmr","bel","","","","pnq","iqr","vuz","","","","","dzo","","len","xui","hla","qpj","sth","fwz","zss","","","tko","","","ele","","muv","","nsa","","","gee","","","","riv","","ztg","","pst","","","","","nsa","mro","","hty","","","soa","","nlb","uae","","aoj","ovt","gyh","","","","cee","","mpo","","qgb","","","","","","uqx","mbg","ocw","pyw","","skv","imr","","","","","ubi","qqa","","ogc","uqm","rge","","","cop","","bcz","","","paa","","","","","","","","","jgx","","","aai","bwy","","zuo","","","wvp","svc","","","opv","noi","","","","","uae","","","amw","","","","","wsp","","","","","okq","owp","cqd","","","kiu","","","zba","gyh","bae","asd","","moz","","","foa","ztg","","foa","fof","","prf","","dki","hty","kcd","dzo","gje","ray","","zsw","","xui","kxs","","","fjp","","tnp","ifa","","","","rvp","hrt","vzv","","","","","","","jxo","zss","","opv","","pdd","ivh","gmq","","","","","dnb","","","dci","","uya"]

        [Theory]
        [InlineData(new string[] { "KiTe", "kite", "hare", "Hare" },
            new string[] { "kite", "Kite", "KiTe", "Hare", "HARE", "Hear", "hear", "keti", "keet", "keto" },
            new string[] { "kite", "KiTe", "KiTe", "Hare", "hare", "", "", "KiTe", "", "KiTe" })]
        [InlineData(new string[] { "yellow" },
            new string[] { "YellOw" },
            new string[] { "yellow" })]

        public void Test1(string[] wordlist, string[] queryList, string[] expected)
        {
            var container = new VowelSpellchecker();
            var result = container.Spellchecker(wordlist, queryList);

            Assert.Equal(expected, result);
        }
    }
}