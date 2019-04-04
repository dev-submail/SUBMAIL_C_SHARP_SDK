# **C#SDK**
### 概览 
- 支持NET版本：4.5 以上 代码编码格式：utf-8。
- 引入方式：直接将SDK中的Submaill.dll和Newtonsoft.Json.dll导入
- **依赖**
- 依赖第三方库Newtonsoft.Json.dll

---
### 下载
[SUBMAIL_CSHARP_SDK](https://github.com/dev-submail/SUBMAIL_C_SHARP_SDK)         [前往Github下载](https://github.com/dev-submail/SUBMAIL_C_SHARP_SDK)

---

#### 文件目录索引 
##### Submail:
	AppConfig
		IAppConfig.cs            配置接口文件
		MailAppConfig.cs	     邮件配置文件	
		MessageConfig.cs         短信配置文件
		VoiceAppConfig.cs	     语音验证配置文件
		InternationalSmsConfig.cs国际短信配置文件
		MMSConfig.cs             彩信配置文件

	Lib
		AddressBookMail.cs     邮件地址薄，订阅和添加联系人到目标地薄 
		AddressBookMessage.cs  短信地址薄，订阅和添加联系人到目标地薄
		ISender.cs		   	   发送接口	
		SendBase.cs		       Message Send 和Mail Send的基类
		Mail.cs		  	       邮件API	
		Message.cs		   	   短信API
		Voice                  语音API
		InterbationalSms       国际短信API
		MailSend.cs		   	   mail/send
		MailXSend.cs	   	   mail/xsend	
		MessageSend            message/send
		MessageXSend.cs	   	   message/xsend
		MessageMultiSend.cs    message/multi-xsend
		MessageLog             短信日志API
		MessageTemplate        短信模板操作
		VoiceSend.cs	       voice/send
		VoiceXsend.cs          voice/xsend
		VoiceMutilXSend        voice/mutilxsend
		VoiceVerify            语音验证码
		InternationalsmsXSend  internationalsms/xsend
		InternationalsmsSend   internationalsms/send
		InternationalsmsMultiXSend internationalsms/multixsend
		MMSXSend                彩信Xsend api
		MMSMultiXsend	        彩信群发xsend接口
	Utility
		HttpWebHelper.cs	     处理HTTP请求
		RequestHelper.cs		 处理请求数据
		SignatureHelper.cs       处理请求数据
		
	SubMailTest:
	    AddressBookMailDemo.cs	    邮件地址薄测试程序
	    AddressBookMessageDemo.cs	短信地址薄测试程序
	    MailSendDemo.cs			    邮件send测试程序
	    MailSendXDemo.cs			邮件XSend测试程序
	    MessageMultiXSendDemo.cs	短信多方发送测试程序
	    MessageSendXDemo.cs		    短信XSend发送测试程序
	    MessageSendDemo             短信send发送测试程序
	    MessageLogDemo              短信日志查询测试程序
	    MessageTemplateDemo         短信模板操作测试程序
	    VoiceSendDemo.cs			语音send测试程序
	    VoiceXSendDemo.cs           语音Xsend发送测试程序
	    VoiceMutilXSendDemo.cs      语音群发测试程序
	    VoiceVerifyDemo.cs          语音验证码测试程序
	    InternationalsmsXSendDemo.cs 国际短信Xsend发送测试程序
		InternationalsmsSendDemo.cs  国际短信send发送测试程序
		InternationalsmsMultiXSendDemo.cs 国际短信群发测试程序
		MMSXSendDemo.cs               彩信xsend测试程序
		MMSXSendDemo.cs               彩信xsend测试程序
		
		

---

#### 开始使用 
##### SDK CLASS索引
	    
```
        AddressBookMail.cs     邮件地址薄，订阅和添加联系人到目标地薄 
		AddressBookMessage.cs  短信地址薄，订阅和添加联系人到目标地薄
		ISender.cs		   	   发送接口	
		SendBase.cs		       Message Send 和Mail Send的基类
		Mail.cs		  	       邮件API	
		Message.cs		   	   短信API
		Voice                  语音API
		InterbationalSms       国际短信API
		MailSend.cs		   	   mail/send
		MailXSend.cs	   	   mail/xsend	
		MessageSend            message/send
		MessageXSend.cs	   	   message/xsend
		MessageMultiSend.cs    message/multi-xsend
		MessageLog             短信日志API
		MessageTemplate        短信模板操作
		VoiceSend.cs	       voice/send
		VoiceXsend.cs          voice/xsend
		VoiceMutilXSend        voice/mutilxsend
		VoiceVerify            语音验证码
		InternationalsmsXSend  internationalsms/xsend
		InternationalsmsSend   internationalsms/send
		InternationalsmsMultiXSend internationalsms/multixsend
		MMSXsend                mms/xsend
		MMSMultiXsend           mms/multixsend
```

		

---
		
#### MailSend 类
##### 初始化: 
-  IAppConfig mailConfig = new MailAppConfig("AppID","AppKey");
- MailSend submail = new MailSend(mailConfig);<br/>

**使用指引:**

方法 | 描述 
---|---
AddTo | 添加邮件地址到 To 数组，第一个必选参数：邮件地址。第二个可选参数：收件人姓名
AddAddressBook | 添加地址薄标识到 addressbook 数组
SetSender | 设置发件人，第一个必选参数：邮件地址。第二个可选参数：显示名称
SetReply | 设置回复地址
AddCc | 添加抄送地址
AddBcc | 添加密送地址
SetSubject | 设置邮件标题
SetText | 设置文本邮件内容
SetHtml | 设置 HTML 邮件内容
AddVar | 添加文本变量到 vars 数组
AddLink | 添加超链接变量到 links 数组
AddHeaders | 添加自定义邮件头指令到 headers 数组
AddAttachment | 添加附件到 attachments 数组
AddTag |  添加项目标记，此参数用于标记一次 API 请求（最大长度不超过 32 位）添加了 tag 参数的 API 请求，会在所有的 SUBHOOK 事件中携带此参数。
Send（） | 发送邮件

**代码示列：**

```
使用 MailSend 类提交 mail/send 发送一封简单的邮件
MailAppConfig("AppID", "AppKey");
MailSend submail = new MailSend(mailConfig);
submail.AddTo("youremail@XXX.com", "yourname");
submail.AddCc("leo@submail.cn", "leo");
submail.AddBcc("leo@submail.cn", "leo");
submail.SetSender("leo@inside.submail.me", "leo");
submail.SetReply("service@submail.cn");
submail.SetSubject("发送历史与明细");
submail.SetText("发送历史与明细");
submail.AddAttachment(@"C:\attachment.txt");
submail.AddTag("XXX");

string resultMessage = string.Empty 
if (submail.Send(out resultMessage)== false)
{
   Console.WriteLine(resultMessage); 
}

```

---

#### MailXSend
-  IAppConfig mailConfig = new MailAppConfig("AppID","AppKey");
- MailXSend submail = new MailXSend(mailConfig);<br/>

**使用指引:**

方法  | 描述 
---|---
AddTo | 添加邮件地址到 To 数组，第一个必选参数：邮件地址。第二个可选参数：收件人姓名
AddAddressBook | 添加地址薄标识到 addressbook 数组
SetSender | 设置发件人，第一个必选参数：邮件地址。第二个可选参数：显示名称
SetReply | 设置回复地址
AddCc | 添加抄送地址
AddBcc | 添加密送地址
SetSubject | 设置邮件标题
SetProject | 设置邮件项目标识
AddVar | 添加文本变量到 vars 数组
AddLink | 添加超链接变量到 links 数组
AddHeaders | 添加自定义邮件头指令到 headers 数组
AddAttachment | 添加附件到 attachments 数组
AddTag |  添加项目标记，此参数用于标记一次 API 请求（最大长度不超过 32 位）添加了 tag 参数的 API 请求，会在所有的 SUBHOOK 事件中携带此参数。
GetSender()	 | 获取发送方式
XSend | 发送邮件

**代码示例:**

```
使用 MAILXsend 类提交 mail/xsend 发送一封邮件。

           IAppConfig mailConfig = new MailAppConfig("AppId", "AppKey");
            MailXSend submail = new MailXSend(mailConfig);
            submail.AddTo("youremail@mail.com", "yourname");
            submail.SetSender("leo@inside.submail.me", "leo");
            submail.SetProject("7pfhZ3");
            submail.AddHeaders("X-Accept", "zh-cn");
            submail.AddHeaders("X-Mailer", "leo App");
            submail.AddTag("XXX");
            string resultMessge = string.Empty;
            if(submail.XSend(out resultMessge) == false)
            {
   Console.WriteLine(resultMessge);
            } 


```

---

#### MessageSend 类
-  IAppConfig messageConfig = new MessageConfig("AppID","AppKey");
- MessageSend submail = new MessageSend(messageConfig);<br/>

**使用指引:**

方法  | 描述 
---|---
AddTo | 添加手机联系人
AddContent | 添加短信正文（传入的短信正文需要与模板匹配，匹配度为75%左右）
AddTag |  添加项目标记，此参数用于标记一次 API 请求（最大长度不超过 32 位）添加了 tag 参数的 API 请求，会在所有的 SUBHOOK 事件中携带此参数。
GetSender()	 | 获取发送方式
Send | 发送短信

**代码示列：**

```
   IAppConfig appConfig = new MessageConfig("appid", "appkey");
            MessageSend messageSend = new MessageSend(appConfig);
            messageSend.AddTo("telephone_number");
            messageSend.AddContent("【SUBMAIL】你好，你的验证码是：38385");
            messageSend.AddTag("XXXX");
            string returnMessage = string.Empty;
            if (messageSend.Send(out returnMessage) == true)
            {
                Console.WriteLine("发送成功");
                Console.WriteLine(returnMessage);
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("发送失败");
                Console.WriteLine(returnMessage);
                Console.ReadKey();
            }

```

---

#### MessageXSend 类
-  IAppConfig messageConfig = new MessageConfig("AppID","AppKey");
- MessageXSend submail = new MessageXSend(messageConfig);<br/>

**使用指引:**

方法  | 描述 
---|---
AddTo | 添加手机联系人
AddVar | 添加文本变量到 vars 数组
AddTag | 添加项目标记，此参数用于标记一次 API 请求（最大长度不超过 32 位）添加了 tag 参数的 API 请求，会在所有的 SUBHOOK 事件中携带此参数。
SetProject | 设置项目Id
GetSender()	 | 获取发送方式
XSend | 发送短信

**代码示列：**

```
     IAppConfig appConfig = new MessageConfig("appid", "appkey", SignType.sha1);
            MessageXSend messageXSend = new MessageXSend(appConfig);
            messageXSend.AddTo("telephone_number");
            messageXSend.SetProject("w3nla3");
            messageXSend.AddVar("code", "1111");
            messageXSend.AddVar("minue", "3359");
            messageXsend.AddTag("XXX");
            string returnMessage = string.Empty;
            if (messageXSend.XSend(out returnMessage) == true)
            {
                Console.WriteLine("发送成功");
                Console.WriteLine(returnMessage);
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("发送失败");
                Console.WriteLine(returnMessage);
                Console.ReadKey();
            }

```

---

#### MessageMutilXSend 类
-  IAppConfig messageConfig = new MessageConfig("AppID","AppKey");
- MessageMutilXSend submail = new MessageMutilXSend(messageConfig);

**使用指引:**

方法  | 描述 
---|---
SetProject | 设置项目Id
SetMulti| 设置多个发送对象信息
AddTag | 添加项目标记，此参数用于标记一次 API 请求（最大长度不超过 32 位）添加了 tag 参数的 API 请求，会在所有的 SUBHOOK 事件中携带此参数。
GetSender()	 | 获取发送方式
MultiXSend| 发送短信

**代码示列：**

```
      IAppConfig appConfig = new MessageConfig("appid", "appkey");
            MessageMultiXSend messageMultiSend = new MessageMultiXSend(appConfig);
            messageMultiSend.SetProject("w3nla3");
            messageMultiSend.AddTag("XXXX");

            Dictionary<string, string> vars = new Dictionary<string, string>();
            vars.Add("code", "123456777");
            vars.Add("minue","18");
            messageMultiSend.SetMulti(new List<MultiMessageItem>() {
                new MultiMessageItem() { to="telephone_number",vars=vars},
                new MultiMessageItem() { to="telephone_number", vars = vars}
            });

            string returnMessage = string.Empty;
           
                if (messageMultiSend.MultiXSend(out returnMessage)== true)
                {
                    Console.WriteLine("发送成功");
                    Console.WriteLine(returnMessage);
                    Console.ReadKey();
                }
                else
                {
                    Console.WriteLine("发送失败");
                    Console.WriteLine(returnMessage);
                    Console.ReadKey();
                }

```


---

#### MessageTemplate 类
-  IAppConfig messageConfig = new MessageConfig("AppID","AppKey");
- MessageTemplate submail = new MessageTemplate(messageConfig);

**使用指引:**

方法  | 描述 
---|---
AddTemplateId | get方法获取模板信息时，添加模板id
PutTemplateId| put请求，修改需要更新的模板id
PutSmsTitle |  put请求，修改模板标题
PutSmSSignature| put请求，修改短信模板签名
PutSmsContent | put请求，修改短信模板正文
delTemplateId| Delete请求，传入需要删除的模板id
PostSmsTitle | post请求，提交模板标题。
PostSmSSignature| post请求，提交短信模板签名
PostSmsContent| post请求，提交短信模板正文
GetSender()	 | 获取发送方式
Get()	 | 通过get获取短信模板信息
Put()	 | 通过put发送请求来修改已存在模板信息
Delete()	 | 删除一个现有模板
Post()	 | 提交一个新的模板


**代码示列：**

```
     IAppConfig appConfig = new MessageConfig("appid","appkey",SignType.sha1);
            MessageTemplate messageTemplate = new MessageTemplate(appConfig);

            //get
            //messageTemplate.AddTemplateId("w3nla3");
            //string returnMessage = string.Empty;
            //returnMessage = messageTemplate.Get(out returnMessage);
            //Console.WriteLine("接口返回消息：" + returnMessage);
            //Console.ReadKey();

            //put
            //messageTemplate.PutTemplateId("9qvwv2");
            //messageTemplate.PutSmsTitle("上海赛邮");
            //messageTemplate.PutSmsContent("你好，你的验证码是：11122233");
            //messageTemplate.PutSmSSignature("【SUBMAIL】");
            //string returnMessage = string.Empty;
            //returnMessage = messageTemplate.Put(out returnMessage);
            //Console.WriteLine("接口返回消息：" + returnMessage);
            //Console.ReadKey();


            //del
            //messageTemplate.delTemplateId("9qvwv2");
            //string returnMessage = string.Empty;
            //returnMessage = messageTemplate.Delete(out returnMessage);
            //Console.WriteLine("接口返回消息：" + returnMessage);
            //Console.ReadKey();

            //post
            messageTemplate.PostSmsTitle("张杨你好");
            messageTemplate.PostSmsContent("你好，你的验证码是：110114");
            messageTemplate.PostSmSSignature("【SUBMAIL】");
            string returnMessage = string.Empty;
            returnMessage = messageTemplate.Post(out returnMessage);
            Console.WriteLine("接口返回消息：" + returnMessage);
            Console.ReadKey();

```

---

#### MessageLog类
-  IAppConfig messageConfig = new MessageConfig("AppID","AppKey");
- MessageLog submail = new MessageLog(messageConfig);

**使用指引:**

方法  | 描述 
---|---
AddRecipient | 添加联系人
AddProject| 添加项目标识
AddResult_status |  添加发送状态（delivered , dropped）
AddStart_data| 添加日志查询的开始时间（使用 UNIX 时间戳格式）
AddEnd_data | 添加日志查询的结束时间（使用 UNIX 时间戳格式）
AddOrder_by| 添加返回数据时执行的升序或降序（asc or desc）
AddRows | 添加单次返回数据的行数
AddOffset| 添加数据偏移指针
GetSender()	 | 获取发送方式
Log() |发送请求获取短信日志


**代码示列：**

```
      IAppConfig appConfig = new MessageConfig("15484", "047b85b5a7e907397033e360f05690dc",SignType.sha1);
            MessageLog messageLog = new MessageLog(appConfig);
            messageLog.AddProject("d5ngn3");
            messageLog.AddStart_data(setUinxTimeStamp(new DateTime(2017, 8, 20, 1, 10, 10)).ToString());
            messageLog.AddEnd_data(setUinxTimeStamp(new DateTime(2017, 12, 1, 1, 10, 10)).ToString());
            string returnMessage = string.Empty;
             returnMessage=messageLog.Log(out returnMessage);
                Console.WriteLine("接受的消息"+returnMessage);
                Console.ReadKey();
      }    
        public long  setUinxTimeStamp(DateTime dateTime)
        {
              DateTime startTime = TimeZone.CurrentTimeZone.ToLocalTime(new DateTime(1970, 1, 1));       
            long timeStamp = (long)(dateTime - startTime).TotalSeconds; // 相差秒数
            return timeStamp;
     }

```

---

#### AddressBookMessage类
-  AppConfig appConfig = new MessageConfig("AppId", "AppKey");
- AddressBookMessage addressbook = new AddressBookMessage(config);


**使用指引:**

方法  | 描述 
---|---
SetAddress	 | 设置联系人11位手机号码
SetAddressbook| 设置目标地址薄标识
Subscribe |  订阅或添加联系人
UnSubscribe	| 退订或移除联系人
GetSender()	 | 获取发送方式


**代码示列：**

```
      使用 ADDRESSBOOKMessage 类 发送 addressbook/message/subscribe 请求，添加订阅联系人或向目标地址薄中添加联系人
     IAppConfig appConfig = new MessageConfig("AppId", "AppKey");
            AddressBookMessage addressBookMessage = new AddressBookMessage(appConfig);
            string returnMessage = string.Empty;
            addressBookMessage.SetAddress("your phone number");
            if (addressBookMessage.Subscribe(out returnMessage) == false)
            {
                Console.WriteLine(returnMessage);
            }

```


#### AddressBookMail类
-  IAppConfig mailConfig = new MailAppConfig("AppID","AppKey");
- AddressBookMail addressBookMail = new AddressBookMail(mailConfig);


**使用指引:**

方法  | 描述 
---|---
SetAddress	 | 设置邮件地址，第一个必选参数：邮件地址。第二个可选参数：收件人姓名
SetAddressbook| 设置目标地址薄标识
Subscribe |  订阅或添加联系人
UnSubscribe	| 退订或移除联系人
GetSender()	 | 获取发送方式


**代码示列：**

```
      使用 ADDRESSBOOKMail 类提交 addressbook/mail/subscribe 请求，添加订阅联系人或向目标地址薄中添加联系人
            IAppConfig mailConfig = new MailAppConfig("AppID","AppKey");
            AddressBookMail addressBookMail = new AddressBookMail(mailConfig);
            addressBookMail.SetAddress("leo12@submail.cn", "leo");
            addressBookMail.SetAddressBook("61RgC3");
            string outMessage = string.Empty;
            bool issuccess = addressBookMail.Subscribe(out outMessage);
            if (!issuccess)
            {
                Console.WriteLine(outMessage);
            }
            
            
            使用 ADDRESSBOOKMail 类提交 addressbook/mail/unsubscribe 请求
            IAppConfig mailConfig = new MailAppConfig("AppID","AppKey");
            AddressBookMail addressBookMail = new AddressBookMail(mailConfig);
            addressBookMail.SetAddress("leo12@submail.cn", "leo");
            string outMessage = string.Empty;
            bool issuccess = addressBookMail.UnSubscribe(out outMessage);
            if (!issuccess)
            {
               Console.WriteLine(outMessage);
            }

```


---

#### VoiceSend类
-  IAppConfig appConfig = new VoiceAppConfig("AppID","AppKey");
-  VoiceSend voiceSend = new VoiceSend(appConfig);


**使用指引:**

方法  | 描述 
---|---
AddTo	 | 设值语音收件人手机号码
AddContent| 设置语音发送正文
GetSender()	 | 获取发送方式
Send| 发送语音


**代码示列：**

```
           IAppConfig appConfig = new VoiceAppConfig("appid", "appkey");
            VoiceSend voiceSend = new VoiceSend(appConfig);
            voiceSend.AddTo("telephone_number");
            voiceSend.AddContent("欢迎来到中国，welcome to china");
            string returnMessage = string.Empty;
            if (voiceSend.Send(out returnMessage) == true)
            {
                Console.WriteLine("发送成功");
                Console.WriteLine(returnMessage);
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("发送失败");
                Console.WriteLine(returnMessage);
                Console.ReadKey();
            }
```

---

#### VoiceXSend类
-    IAppConfig appConfig = new VoiceAppConfig("AppID","AppKey");
-  VoiceXSend voiceXSend = new VoiceXSend(appConfig);

**使用指引:**

方法  | 描述 
---|---
AddTo	 | 设值语音收件人手机号码
SetProject| 设置语音发送模板
AddVar | 添加文本变量到 vars 数组
GetSender()	 | 获取发送方式
XSend| 发送语音


**代码示列：**

```
           IAppConfig appConfig = new VoiceAppConfig("appid", "appkey");
            VoiceXSend voiceXSend = new VoiceXSend(appConfig);
            voiceXSend.AddTo("17602115149");
            voiceXSend.SetProject("WZlIv3");
            voiceXSend.AddVar("name", "张杨");
            voiceXSend.AddVar("place", "江湖大道");
            string returnMessage = string.Empty;
            if (voiceXSend.XSend(out returnMessage) == true)
            {
                Console.WriteLine("发送成功");
                Console.WriteLine(returnMessage);
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("发送失败");
                Console.WriteLine(returnMessage);
                Console.ReadKey();
            }
```

---

#### VoiceMultiXSend类
-    IAppConfig appConfig = new VoiceAppConfig("AppID","AppKey");
-  VoiceMultiXSend voiceMultiXSend = new VoiceMultiXSend(appConfig);

**使用指引:**

方法  | 描述 
---|---
SetProject| 设置语音发送模板
SetMulti | 设置多个发送对象信息
GetSender()	 | 获取发送方式
MultiXSend| 群发语音


**代码示列：**

```
           IAppConfig appConfig = new VoiceAppConfig("appid", "appkey");
            VoiceMultiXSend voiceMultiXSend = new VoiceMultiXSend(appConfig);
            voiceMultiXSend.SetProject("WZlIv3");

            Dictionary<string, string> vars = new Dictionary<string, string>();
            vars.Add("place", "上海");
            vars.Add("name", "张三");

            Dictionary<string, string> vars2 = new Dictionary<string, string>();
            vars2.Add("place", "北京");
            vars2.Add("name", "老江");

            voiceMultiXSend.SetMulti(new List<MultiMessageItem>() {
                new MultiMessageItem() { to="1760115149", vars = vars},
                new MultiMessageItem() { to="1331155482", vars = vars2},
            });

            string returnMessage = string.Empty;
            if (voiceMultiXSend.MultiXSend(out returnMessage) == false)
            {
                Console.WriteLine(returnMessage);
                Console.ReadKey();
            }
```

---
#### VoiceVerify类
-    IAppConfig appConfig = new VoiceAppConfig("AppID","AppKey");
-  VoiceMultiXSend voiceMultiXSend = new VoiceMultiXSend(appConfig);

**使用指引:**

方法  | 描述 
---|---
AddTo| 设置语音验证码接收用户的手机号码
SetCode | 设置语音验证码内容
GetSender()	 | 获取发送方式
Verify（）| 发送语音验证码


**代码示列：**

```
          IAppConfig appConfig = new VoiceAppConfig("appid", "appkey");
            VoiceVerify voiceVerify = new VoiceVerify(appConfig);
            voiceVerify.AddTo("telephone_number");
            voiceVerify.SetCode("38381438");
            string returnMessage = string.Empty;
            if (voiceVerify.Verify(out returnMessage) == true)
            {
                Console.WriteLine("发送成功");
                Console.WriteLine(returnMessage);
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("发送失败");
                Console.WriteLine(returnMessage);
                Console.ReadKey();
            }
```

---

#### InternationalSmsSend类
-    IAppConfig appConfig = new InternationalSmsConfig("AppID","AppKey");
-  InternationalSmsSend internationalSmsSend = new InternationalSmsSend(appConfig);

**使用指引:**

方法  | 描述 
---|---
AddTo| 设置国际短信接收用户的手机号码
AddContent | 设置国际短信正文内容
GetSender()	 | 获取发送方式
Send（）| 发送短信


**代码示列：**

```
            IAppConfig appConfig = new InternationalSmsConfig("appid", "appkey", SignType.normal);
			InternationalSmsSend internationalSmsSend = new InternationalSmsSend(appConfig);
			internationalSmsSend.AddTo("+14375375616");
			internationalSmsSend.AddContent("【SUBMAIL】你好，你的验证码是：38385");
			string returnMessage = string.Empty;
			if (internationalSmsSend.Send(out returnMessage) == true)
			{
				Console.WriteLine("发送成功");
				Console.WriteLine(returnMessage);
				Console.ReadKey();
			}
			else
			{
				Console.WriteLine("发送失败");
				Console.WriteLine(returnMessage);
				Console.ReadKey();
			}
```
---

#### InternationalSmsXSend类
-    AppConfig appConfig = new InternationalSmsConfig("appid", "appkey", SignType.normal);
-  InternationalSmsXSend smsXSend = new InternationalSmsXSend(appConfig);

**使用指引:**

方法  | 描述 
---|---
AddTo| 设置国际短信接收用户的手机号码
SetProject | 设置国际短信模板
AddVar |   添加文本变量到 vars 数组
GetSender()	 | 获取发送方式
XSend（）| 发送短信


**代码示列：**

```
            IAppConfig appConfig = new InternationalSmsConfig("appid", "appkey", SignType.normal);
			InternationalSmsXSend smsXSend = new InternationalSmsXSend(appConfig);
			smsXSend.AddTo("+14375375616");
			smsXSend.SetProject("w3nla3");
			smsXSend.AddVar("code", "1111333");
			smsXSend.AddVar("minue", "2");
			string returnMessage = string.Empty;
			if (smsXSend.XSend(out returnMessage) == true)
			{
				Console.WriteLine("发送成功");
				Console.WriteLine(returnMessage);
				Console.ReadKey();
			}
			else
			{
				Console.WriteLine("发送失败");
				Console.WriteLine(returnMessage);
				Console.ReadKey();
			}
```

---

#### InternationalSmsMultiXSend类
-    IAppConfig appConfig = new InternationalSmsConfig("appid", "appkey");
-  InternationalSmsXSend smsXSend = new InternationalSmsXSend(appConfig);

**使用指引:**

方法  | 描述 
---|---
SetProject | 设置国际短信模板
SetMulti |   设置多个发送对象信息
GetSender()	 | 获取发送方式
MultiXSend（）| 发送短信


**代码示列：**

```
           IAppConfig appConfig = new InternationalSmsConfig("appid", "appkey", SignType.normal);
			InternationalSmsMultiXSend smsMultiXSend = new InternationalSmsMultiXSend(appConfig);
			smsMultiXSend.SetProject("w3nla3");

			Dictionary<string, string> vars = new Dictionary<string, string>();
			vars.Add("code", "11122233");
			vars.Add("minue", "18");
			smsMultiXSend.SetMulti(new List<MultiMessageItem>() {
				new MultiMessageItem() { to="+14375375616",vars=vars},
				new MultiMessageItem() { to="+17828203943", vars = vars}
			});

			string returnMessage = string.Empty;

			if (smsMultiXSend.MultiXSend(out returnMessage) == true)
			{
				Console.WriteLine("发送成功");
				Console.WriteLine(returnMessage);
				Console.ReadKey();
			}
			else
			{
				Console.WriteLine("发送失败");
				Console.WriteLine(returnMessage);
				Console.ReadKey();
			}
```

---

#### MMSXSend 类
-  IAppConfig mmsConfig = new MMSConfig("AppID","AppKey",SignType.normal);
- MMSXSend submail = new MMSXSend(mmsConfig);

**使用指引:**

方法  | 描述 
---|---
AddTo | 添加手机联系人
AddVar | 添加文本变量到 vars 数组
AddTag | 添加项目标记，此参数用于标记一次 API 请求（最大长度不超过 32 位）添加了 tag 参数的 API 请求，会在所有的 SUBHOOK 事件中携带此参数。
SetProject | 设置项目Id
GetSender	 | 获取发送方式
XSend | 发送短信

**代码示列：**

```
            IAppConfig appConfig = new MMSConfig("apppid", "appkey", SignType.normal);
			MMSXSend smsXSend = new MMSXSend(appConfig);
			smsXSend.AddTo("14xxx375616");
			smsXSend.SetProject("w3nla3");
			smsXSend.AddVar("code", "1111333");
			smsXSend.AddVar("minue", "2");
			string returnMessage = string.Empty;
			smsXSend.XSend(out returnMessage);
			Console.WriteLine(returnMessage);
			Console.ReadKey();
```

---

#### MMSMutilXSend 类
-  IAppConfig appConfig = new MMSConfig("AppID","AppKey","normal");
- MMSMutilXSend submail = new MMSMutilXSend(appConfig);

**使用指引:**

方法  | 描述 
---|---
SetProject | 设置项目Id
SetMulti| 设置多个发送对象信息
AddTag | 添加项目标记，此参数用于标记一次 API 请求（最大长度不超过 32 位）添加了 tag 参数的 API 请求，会在所有的 SUBHOOK 事件中携带此参数。
GetSender()	 | 获取发送方式
MultiXSend| 发送短信

**代码示列：**

```
         
			IAppConfig appConfig = new MMSConfig("apppid", "appkey", SignType.normal);
			MMSMultiXSend smsMultiXSend = new MMSMultiXSend(appConfig);
			smsMultiXSend.SetProject("wxxxa3");

			Dictionary<string, string> vars = new Dictionary<string, string>();
			vars.Add("code", "11122233");
			vars.Add("minue", "18");
			smsMultiXSend.SetMulti(new List<MultiMessageItem>() {
				new MultiMessageItem() { to="1437xxxx616",vars=vars},
				new MultiMessageItem() { to="1782xxxx943", vars = vars}
			});

			string returnMessage = string.Empty;
			smsMultiXSend.MultiXSend(out returnMessage);
			Console.WriteLine(returnMessage);
			Console.ReadKey();

```


---



具体参数参数传入请参考我们的开发文档[https://www.mysubmail.com/chs/documents/developer/index](https://www.mysubmail.com/chs/documents/developer/index)

