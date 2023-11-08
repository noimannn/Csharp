using Email;

var enviador = new SendEmail();


while (true) ;
if (DateTime.Now.ToString("HH-mm")== "11-05")
{
    enviador.sendMail("luan.neumann@abase.com.br", "ola,beleza", "email");

}
Thread.Sleep(60000);

