# 架构说明文档

## 项目说明

### 1. Project.Web.Host

基本属于固定的写法，这里定义了一个Web项目，用于封装整个Abp框架，
其模块 WebHostModule 需要继承 WebCoreModule, 其他为固定写法

### 2. Project.Web.Core

展现层：Web的对外展现层，封装Id，Auth等相关信息
其模块 WebCoreModule, 需要继承Web相关的基础模块，如 AbpAspNetCoreModule、AbpAspNetCoreSignalRModule
同时，继承ApplicationModule

### 3. Project.Application

应用层：整体项目的核心，定义包括项目服务（Service）、实体（DtoEntity）信息，主要是根据一个输入Dto，返回另外一个输出Dto。
对于一些简单的操作，可以直接调用存储仓库，也可以调用Project.Core中的方法来进行操作实现。

其模块 ApplicationModule，需要继承 AbpAutoMapperModule 来实现实体与DB数据的转换

注： 拆分成IService和Service？Module主要在Service中实现

### 4. Project.Core

领域层： 定义DB实体信息，以及仓储对象，定义基于AutoMapper的映射规则，以及其他的流程逻辑（XXXManager）

### 5. Project.EFCore

实体框架层：同时是基于存储仓库的实现

### 5. Project.Miggration

数据迁移工具

## 权限验证说明，

