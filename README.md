# BrdataTeste
# EntityFramework Versão 6.1.3 foi usada nesse projeto.
# Configurar Conexão com o Banco de dados "App.Config".

	<connectionStrings>
		<add name="Connection"
		connectionString="Data Source=STIGMA\SQLEXPRESS;Initial Catalog=DBBruno;Integrated Security=true"
		providerName="System.Data.SqlClient"/>
	</connectionStrings>
 
 Source=STIGMA\SQLEXPRESS 
 
 ![image](https://user-images.githubusercontent.com/67505790/169731715-8fce3f4e-e4b5-4e87-851c-d9d7b23290a2.png)

 Para escolher qual Banco você quer ou criar com o nome que deseja apenas altere esse linha
 
Catalog=DBBruno
Catlog=Qualquernome
Ele cria automatico ja o banco com esse nome

Não esta configurado no banco limitações de caracteres vou implementar isso ainda.

# Precisa apenas do SQL Server Instalado na Maquina com as estancias ativas, de resto o Entity faz a Magica dele.
