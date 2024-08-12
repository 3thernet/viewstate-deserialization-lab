# ViewState 反序列化测试环境

本项目用于学习如何在 ASP.NET 应用程序中发现和利用 ViewState 漏洞。

## 安装与配置

### 1. 克隆项目

```bash
git clone https://github.com/3thernet/viewstate-deserialization-lab.git
```

### 2. 配置IIS

- “启用或关闭 Windows 功能”，勾选"Internet Information Services"，展开选项继续勾选"万维网服务"->"应用程序开发功能"下的".NET Extensibility 4.8"和"ASP.NET 4.8"
- 在 IIS 中创建一个新的网站，将物理目录指向克隆的项目目录。

### 3. 配置`Web.config`

默认开启了ViewState签名和加密，可根据实验需要关闭

```
<pages enableViewStateMac="true" viewStateEncryptionMode="Always" controlRenderingCompatibilityVersion="4.5"/>
```

# 
