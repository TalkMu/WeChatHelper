#include "websocketpp/config/asio_no_tls_client.hpp"
#include "websocketpp/client.hpp"
#include <iostream>
#include <string>
#include "CJsonObject.hpp"

typedef websocketpp::client<websocketpp::config::asio_client> client;
typedef websocketpp::config::asio_client::message_type::ptr message_ptr;

using websocketpp::lib::placeholders::_1;
using websocketpp::lib::placeholders::_2;
using websocketpp::lib::bind;
using namespace std;

// 初始化Socket
void InitWebSocket();

// 停止Socket
void StopWebSocket();

// 开启
void OnOpen(client* c, websocketpp::connection_hdl hdl);

// 关闭
void OnClose(client* c, websocketpp::connection_hdl hdl);

void OnTermination(client* c, websocketpp::connection_hdl hdl);

// 接受消息
void RecvMessage(client* wsclient, websocketpp::connection_hdl hdl, message_ptr msg);

// 发送消息
void Send(int code, neb::CJsonObject data);
void Send(int code, neb::CJsonObject data, string callback, wstring msg);