# ViewState 反序列化测试环境

本项目用于学习如何在 ASP.NET 应用程序中发现和利用 ViewState 漏洞。

## 安装与配置

### 1. 克隆项目

```bash
git clone https://github.com/3thernet/viewstate-deserialization-lab.git
cd viewstate-vulnerability-lab
```

### 2. 配置IIS

- 在 IIS 中创建一个新的应用程序池，并设置其 .NET CLR 版本为 **v4.0**。
- 在 IIS 中创建一个新的网站，将根目录指向克隆的项目目录。

### 3. 配置`Web.config`

默认开启了ViewState签名和加密，可根据实验需要关闭

```
<pages enableViewStateMac="true" viewStateEncryptionMode="Always" controlRenderingCompatibilityVersion="4.5"/>
```

## 处理 HTTP 错误 404.3 - Not Found

**由于扩展配置问题而无法提供您请求的页面。如果该页面是脚本，请添加处理程序。如果应下载文件，请添加 MIME 映射。**

确保安装和启用必要的 IIS 功能，特别是 ASP.NET 和 .NET Framework 相关的功能。

- 打开“控制面板” -> “程序和功能” -> “启用或关闭 Windows 功能”->“Internet Information Services“->“万维网服务“->“应用程序开发功能“。

- 确保以下功能已启用：
  
  - `.NET Framework 4.x` （或项目使用的其他版本）
  - `ASP.NET 4.x` 

- 重启IIS服务器：`iisreset`
