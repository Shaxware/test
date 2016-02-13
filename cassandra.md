# Cassandra のインストール on Ubuntu

## Oracle Java 8 のインストール

- sudo add-apt-repository ppa:webupd8team/java
- sudo apt-get update
- sudo apt-get install oracle-java8-installer

## Cassandra のインストール
[ここ](http://docs.datastax.com/en/cassandra/3.x/cassandra/install/installDeb.html)参照

- echo "deb http://debian.datastax.com/datastax-ddc 3.2 main" | sudo tee -a /etc/apt/sources.list.d/cassandra.sources.list
- curl -L https://debian.datastax.com/debian/repo_key | sudo apt-key add -
- sudo apt-get update
- sudo apt-get install datastax-ddc

インストール後、以下をやっとけ、とも書いてある。

- sudo service cassandra stop
- sudo rm -rf /var/lib/cassandra/data/system/*

## /etc/cassandra/cassandra.yaml の編集

### cluster_name
cluster_nameはクラスタごとに同じ名前を設定すること。
cluster_name: 'Test Cluster J'

### seeds
追加されたノードがまずアクセスしにいくノードのアドレス。複数定義可能。
seeds: "192.168.10.10"

### listen_address / listen_interface
他のノードがアクセスするアドレスまたはネットワークインターフェース。自ノードはこのアドレスにポートを開けて待つことになる。
listen_address を無効にして、listen_interface を eth0 とか eth1 にするのがいいみたい。

### rpc_address / rpc_interface
クライアントがThrift RPCかネイティブプロトコルを使ってアクセスする際のアドレスまたはネットワークインターフェース。自ノードはこのアドレスにポートを開けて待つことになる。
rpc_address を無効にして、rpc_interface を eth0 とか eth1 にするのがいいみたい。

### endpoint_snitch
(デフォルト:org.apache.cassandra.locator.SimpleSnitch)ノードの特定と要求の転送にCassandraが使用するスニッチを設定します。IEndpointSnitchを実装しているクラスを設定する必要があります。使用可能なスニッチの説明については、「スニッチ」を参照してください。
注: 実稼働環境にはGossipingPropertyFileSnitchを推奨します。これはノードのデータ・センターとラックを定義し、この情報をその他のノードに伝えるためにゴシップを使用します。

## cassandra-rackdc.properties の編集（データセンターの設定だけ）

dc

dc=DC1

rack

rack=RAC1


