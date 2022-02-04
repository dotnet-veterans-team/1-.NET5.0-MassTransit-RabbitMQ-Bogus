# .NET 5.0 + MassTransit + RabbitMQ + Bogus

[![N|MassTransit](https://masstransit-project.com/mt-logo-small.png)](https://masstransit-project.com/)
[![N|MassTransit](https://pbs.twimg.com/profile_images/1223261138059780097/eH73w5lN_normal.jpg)](https://www.rabbitmq.com/)
[![N|MassTransit](https://raw.githubusercontent.com/bchavez/Bogus/master/Docs/logo.png)](https://github.com/bchavez/Bogus/)

## => Recentemente resolvi estudar e conhecer melhor a combinação do MassTransit e RabbitMQ.

 - ### API com .NET 5.0 Será a nossa API que receberá as requisições e irá incluir as mensagens na fila.
 - ### MassTransit nos ajuda com uma série de recursos para construção de serviços assíncronos de longa duração.
 - ### RabbitMQ é o nosso servidor de mensageria (AMQP) para lidar com o tráfego de forma eficiente e confiável.
 - ### Bogus que é um pacote muito bacana e vamos utilizar para gerar grande volume de dados fakes com muito pouco esforço.
 - ### Windows Forms Application que irá simular as vendas (PDV's)
 - ### Console Application que será nosso consumidor de mensagens

## Instalação do RabbitMQ
- Antes de baixar o arquivo de instalação do RabbitMQ é importante baixar a instalação do Erlang pelo link [https://www.erlang.org/downloads]
- Instalar o RabbitMQ utilizando o arquivo de instalação diretamente pelo link [https://www.rabbitmq.com/download.html] ou pode também obter uma imagem docker sem a necessidade de instalar o serviço na sua máquina (Melhor opção).

```bash
docker run -it --rm --name rabbitmq -p 5672:5672 -p 15672:15672 rabbitmq:3.9-management
```
[![N|](https://cdn-images-1.medium.com/max/800/1*eoV2JKsGcShlulzzsehEgA.png)]
Após os passos citados, um serviço no windows será instalado, desta forma você já terá acesso ao servidor do RabbitMQ (Caso de instalação direta).

## Utilização

Basta agora acessar o link http://localhost:15672/#/ com o servidor ativo do RrabbitMq, onde podemos ver entre várias informações as fila(s) trabalhando.
User: guest
Pass: guest

[![N|](https://cdn-images-1.medium.com/max/800/1*6GI-zNOfZFEuL55cssFmbw.png)]

Agora é só executar o projeto!! Será possível obervar consumer + api + pdv (Windows Forms) trabalhando em conjunto!!

Abraço!!!

Marca lá a Star!!!
