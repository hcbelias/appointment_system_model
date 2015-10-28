using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiningMath
{
    public class NFeStructure
    {

        public class Valores
        {

            public string ValorServicos { get; set; }
            public string ValorPis { get; set; }
            public string ValorCofins { get; set; }
            public string ValorIr { get; set; }
            public string ValorCsll { get; set; }
            public string IssRetido { get; set; }
            public string ValorIss { get; set; }
            public string ValorIssRetido { get; set; }
            public string BaseCalculo { get; set; }
            public string Aliquota { get; set; }
            public string ValorLiquidoNfse { get; set; }
        }

        public class Servico
        {
            public Valores Valores { get; set; }
            public string ItemListaServico { get; set; }
            public string CodigoTributacaoMunicipio { get; set; }
            public string Discriminacao { get; set; }
            public string CodigoMunicipio { get; set; }
        }

        public class IdentificacaoPrestador
        {
            public string Cnpj { get; set; }
            public string InscricaoMunicipal { get; set; }
        }

        public class Endereco
        {
            public string End { get; set; }
            public string Numero { get; set; }
            public string Bairro { get; set; }
            public string CodigoMunicipio { get; set; }
            public string Uf { get; set; }
            public string Cep { get; set; }
        }

        public class Contato
        {
            public string Telefone { get; set; }
            public string Email { get; set; }
        }

        public class PrestadorServico
        {
            public IdentificacaoPrestador IdentificacaoPrestador { get; set; }
            public string RazaoSocial { get; set; }
            public string NomeFantasia { get; set; }
            public Endereco Endereco { get; set; }
            public Contato Contato { get; set; }
        }

        public class CpfCnpj
        {
            public string Cnpj { get; set; }
        }

        public class IdentificacaoTomador
        {
            public CpfCnpj CpfCnpj { get; set; }
            public string InscricaoMunicipal { get; set; }
        }

        public class Endereco2
        {
            public string Endereco { get; set; }
            public string Numero { get; set; }
            public string Complemento { get; set; }
            public string Bairro { get; set; }
            public string CodigoMunicipio { get; set; }
            public string Uf { get; set; }
            public string Cep { get; set; }
        }

        public class TomadorServico
        {
            public IdentificacaoTomador IdentificacaoTomador { get; set; }
            public string RazaoSocial { get; set; }
            public Endereco2 Endereco { get; set; }
        }

        public class OrgaoGerador
        {
            public string CodigoMunicipio { get; set; }
            public string Uf { get; set; }
        }

        public class InfNfse
        {
            public string Numero { get; set; }
            public string CodigoVerificacao { get; set; }
            public string DataEmissao { get; set; }
            public string NaturezaOperacao { get; set; }
            public string OptanteSimplesNacional { get; set; }
            public string IncentivadorCultural { get; set; }
            public string Competencia { get; set; }
            public Servico Servico { get; set; }
            public PrestadorServico PrestadorServico { get; set; }
            public TomadorServico TomadorServico { get; set; }
            public OrgaoGerador OrgaoGerador { get; set; }
            public string _Id { get; set; }
        }

        public class CanonicalizationMethod
        {
            public string _Algorithm { get; set; }
        }

        public class SignatureMethod
        {
            public string _Algorithm { get; set; }
        }

        public class Transform
        {
            public string _Algorithm { get; set; }
        }

        public class Transforms
        {
            public Transform Transform { get; set; }
        }

        public class DigestMethod
        {
            public string _Algorithm { get; set; }
        }

        public class Reference
        {
            public Transforms Transforms { get; set; }
            public DigestMethod DigestMethod { get; set; }
            public string DigestValue { get; set; }
            public string _URI { get; set; }
        }

        public class SignedInfo
        {
            public CanonicalizationMethod CanonicalizationMethod { get; set; }
            public SignatureMethod SignatureMethod { get; set; }
            public Reference Reference { get; set; }
        }

        public class X509Data
        {
            public string X509Certificate { get; set; }
        }

        public class RSAKeyValue
        {
            public string Modulus { get; set; }
            public string Exponent { get; set; }
        }

        public class KeyValue
        {
            public RSAKeyValue RSAKeyValue { get; set; }
        }

        public class KeyInfo
        {
            public X509Data X509Data { get; set; }
            public KeyValue KeyValue { get; set; }
        }

        public class Signature
        {
            public SignedInfo SignedInfo { get; set; }
            public string SignatureValue { get; set; }
            public KeyInfo KeyInfo { get; set; }
            public string _xmlns { get; set; }
            public string _Id { get; set; }
        }

        public class Nfse
        {
            public InfNfse InfNfse { get; set; }
            public List<Signature> Signature { get; set; }
            public string _xmlns { get; set; }
            public string _versao { get; set; }
        }

        public class CompNfse
        {
            public Nfse Nfse { get; set; }
            public string _xmlns { get; set; }
        }

        public class RootObject
        {
            public CompNfse CompNfse { get; set; }
        }
    }
}
