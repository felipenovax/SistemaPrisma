using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace SistemaPrisma
{
    
    class classeFuncionario
    {
        //Atributos de Classe
        private int codBarras;
        private char sexo;
        private String
            nome,
            localNascimento,
            ufNascimento,
            escolaridade,
            cpf,
            rg,
            rguf,
            orgaoexpeditor,
            estadocivil,
            nomepai,
            nomemae,
            endereco,
            numero,
            bairro,
            cidade,
            uf,
            cep,
            telefone,
            celular,
            email,
            codigo,
            setor,
            login,
            cargo,
            empresa,
            //datacadastro,
            centrocusto,
            //dataadmissao,
            responsavel,
            planosaude,
            vt,
            va,
            pis,
            //datapis,
            tituloeleitor,
            secao,
            setortitulo,
            ctps,
            ctpsnumero,
            ctpsserie,
            ctpsestado,
            ctpsexpedicao,
            tipocontrato,
            horarioexpediente,
            salario,
            banco,
            agencia;
            
            

        //private DateTime datanasc, datacadastro;


        //Construtor

        public classeFuncionario()
        {
            
            this.nome = "";
            this.localNascimento = "São Paulo";
            this.ufNascimento = "SP";
            this.sexo = ' ';
            this.escolaridade = null;
            this.cpf = "";
            this.rg = "";
            this.rguf = "";
            this.orgaoexpeditor = "";
            this.estadocivil = "";
            this.nomepai = "";
            this.nomemae = "";
            this.endereco = "";
            this.numero = "";
            this.bairro = "";
            this.cidade = "";
            this.uf = "";
            this.cep = "";
            this.telefone = "";
            this.celular = "";
            this.email = "";
            this.codigo = "";
            this.login = "";
            this.setor = "";
            this.cargo = "";
            //this.datanasc = null;
            this.codBarras = 0;
            this.empresa = "";
            this.centrocusto = "";
            //this.dataadmissao
            this.responsavel = "";
            this.planosaude = "";
            //this.vt = 
            //this.va = 
            this.pis = "";
            //this.datapis
            this.tituloeleitor = "";
            this.secao = "";
            this.setortitulo = "";
            this.ctps = "";
            this.ctpsnumero = "";
            this.ctpsserie = "";
            this.ctpsestado = "";
            this.ctpsexpedicao = "";
            this.tipocontrato = "";
            this.horarioexpediente = "";
            this.salario = "";
            this.banco = "";
            this.agencia = "";



        }

        //Get & Set
        
        public String getNome()
        {
            return nome;
        }
        public void setNome(String nome)
        {
            this.nome = nome;
        }

        public String getLocalNascimento()
        {
            return localNascimento;
        }
        public void setLocalNascimento(String localNascimento)
        {
            this.localNascimento = localNascimento;
        }
        
        public String getUfNascimento()
        {
            return ufNascimento;
        }
        public void setUfNascimento(String ufNascimento )
        {
            this.ufNascimento = ufNascimento ;
        }

        public char getSexo()
        {
            return sexo;
        }
        public void setSexo(char sexo)
        {
            this.sexo = sexo;
        }

        public String getEscolaridade()
        {
            return escolaridade;
        }
        public void setEscolaridade(String escolaridade)
        {
            this.escolaridade = escolaridade;
        }

        public String getCpf()
        {
            return cpf;
        }
        public void setCpf(String cpf)
        {
            this.cpf = cpf;
        }

        public String getRg()
        {
            return rg;
        }
        public void setRg(String rg)
        {
            this.rg = rg;
        }

        public String getRguf()
        {
            return rguf;
        }
        public void setRguf(String rguf)
        {
            this.rguf = rguf;
        }

        public String getOrgaoexpeditor()
        {
            return orgaoexpeditor;
        }
        public void setOrgaoexpeditor(String orgaoexpeditor)
        {
            this.orgaoexpeditor = orgaoexpeditor;
        }

        public String getEstadocivil()
        {
            return estadocivil;
        }
        public void setEstadocivil(String estadocivil)
        {
            this.estadocivil = estadocivil;
        }

        public String getNomepai()
        {
            return nomepai;
        }
        public void setNomepai(String nomepai)
        {
            this.nomepai = nomepai;
        }

        public String getNomemae()
        {
            return nomemae;
        }
        public void setNomemae(String nomemae)
        {
            this.nomemae = nomemae;
        }

        public String getEndereco()
        {
            return endereco;
        }
        public void setEndereco(String endereco)
        {
            this.endereco = endereco;
        }

        public String getNumero()
        {
            return numero;
        }
        public void setNumero(String numero)
        {
            this.numero = numero;
        }

        public String getBairro()
        {
            return bairro;
        }
        public void setBairro(String bairro)
        {
            this.bairro = bairro;
        }

        public String getCidade()
        {
            return cidade;
        }
        public void setCidade(String cidade)
        {
            this.cidade = cidade;
        }

        public String getUf()
        {
            return uf;
        }
        public void setUf(String uf)
        {
            this.uf = uf;
        }

        public String getCep()
        {
            return cep;
        }
        public void setCep(String cep)
        {
            this.cep = cep;
        }

        public String getTelefone()
        {
            return telefone;
        }
        public void setTelefone(String telefone)
        {
            this.telefone = telefone;
        }

        public String getCelular()
        {
            return celular;
        }
        public void setCelular(String celular)
        {
            this.celular = celular;
        }

        public String getEmail()
        {
            return email;
        }
        public void setEmail(String email)
        {
            this.email = email;
        }

        
        public String getCodigo()
        {
            return codigo;
        }
        public void setCodigo(String codigo)
        {
            this.codigo = codigo;
        }

        public String getLogin()
        {
            return login;
        }
        public void setLogin(String login)
        {
            this.login = login;
        }

        public String getSetor()
        {
            return setor;
        }
        public void setSetor(String setor)
        {
            this.setor = setor;
        }

        public String getCargo()
        {
            return cargo;
        }
        public void setCargo(String cargo)
        {
            this.cargo = cargo;
        }

        //adicionar o get & set da dataNascimento aqui!!

        public int getCodBarras()
        {
            return codBarras;
        }
        public void setCodBarras(int codBarras)
        {
            this.codBarras = codBarras;
        }

        public String getCentrocusto()
        {
            return centrocusto;
        }
        public void setCentrocusto(String centrocusto)
        {
            this.centrocusto = centrocusto;
        }

        /*public String getDATAADMISSAO()
        {
            return;
        }
        public void set(String )
        {
            this. = ;
        }*/

        public String getResponsavel()
        {
            return responsavel;
        }
        public void setResponsavel(String responsavel)
        {
            this.responsavel = responsavel;
        }

        public String getPlanosaude()
        {
            return planosaude;
        }
        public void setPlanosaude(String planosaude)
        {
            this.planosaude = planosaude;
        }

        public String getVt()
        {
            return vt;
        }
        public void setVt(String vt)
        {
            this.vt = vt;
        }

        public String getVa()
        {
            return va;
        }
        public void setVa(String va)
        {
            this.va = va;
        }

        public String getPis()
        {
            return pis;
        }
        public void setPis(String pis)
        {
            this.pis = pis;
        }

        public String getTituloeleitor()
        {
            return tituloeleitor;
        }
        public void setTituloeleitor(String tituloeleitor)
        {
            this.tituloeleitor = tituloeleitor;
        }

        public String getSecao()
        {
            return secao;
        }
        public void setSecao(String secao)
        {
            this.secao = secao;
        }

        public String getSetortitulo()
        {
            return setortitulo;
        }
        public void setSetortitulo(String setortitulo)
        {
            this.setortitulo = setortitulo;
        }

        public String getCtps()
        {
            return ctps;
        }
        public void setCtps(String ctps)
        {
            this.ctps = ctps;
        }

        public String getCtpsnumero()
        {
            return ctpsnumero;
        }
        public void setCtpsnumero(String ctpsnumero)
        {
            this.ctpsnumero = ctpsnumero;
        }

        public String getCtpsexpedicao()
        {
            return ctpsexpedicao;
        }
        public void setCtpsexpedicao(String ctpsexpedicao)
        {
            this.ctpsexpedicao = ctpsexpedicao;
        }

        public String getTipocontrato()
        {
            return tipocontrato;
        }
        public void setTipocontrato(String tipocontrato)
        {
            this.tipocontrato = tipocontrato;
        }

        /*public String getHorarioexpediente()
        {
            return horarioexpediente;
        }
        public void setHorarioexpediente(String horarioexpediente)
        {
            this.horarioexpediente = horarioexpediente;
        }*/

        public String getSalario()
        {
            return salario;
        }
        public void setSalario(String salario)
        {
            this.salario = salario;
        }

        public String getBanco()
        {
            return banco;
        }
        public void setBanco(String banco)
        {
            this.banco = banco;
        }

        public String getAgencia()
        {
            return agencia;
        }
        public void setAgencia(String agencia)
        {
            this.agencia = agencia;
        }


        //metodo de conexao

        private MySqlConnection conn;

        public void conexao()
        {
            string connStr = "server=localhost;user=root;database=prisma;port=3306;password='040288fe'";
            conn = new MySqlConnection(connStr);
            conn.Open();
        }

        
       

    }
}
