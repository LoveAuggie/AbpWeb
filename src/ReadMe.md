# �ܹ�˵���ĵ�

## ��Ŀ˵��

### 1. Project.Web.Host

�������ڹ̶���д�������ﶨ����һ��Web��Ŀ�����ڷ�װ����Abp��ܣ�
��ģ�� WebHostModule ��Ҫ�̳� WebCoreModule, ����Ϊ�̶�д��

### 2. Project.Web.Core

չ�ֲ㣺Web�Ķ���չ�ֲ㣬��װId��Auth�������Ϣ
��ģ�� WebCoreModule, ��Ҫ�̳�Web��صĻ���ģ�飬�� AbpAspNetCoreModule��AbpAspNetCoreSignalRModule
ͬʱ���̳�ApplicationModule

### 3. Project.Application

Ӧ�ò㣺������Ŀ�ĺ��ģ����������Ŀ����Service����ʵ�壨DtoEntity����Ϣ����Ҫ�Ǹ���һ������Dto����������һ�����Dto��
����һЩ�򵥵Ĳ���������ֱ�ӵ��ô洢�ֿ⣬Ҳ���Ե���Project.Core�еķ��������в���ʵ�֡�

��ģ�� ApplicationModule����Ҫ�̳� AbpAutoMapperModule ��ʵ��ʵ����DB���ݵ�ת��

ע�� ��ֳ�IService��Service��Module��Ҫ��Service��ʵ��

### 4. Project.Core

����㣺 ����DBʵ����Ϣ���Լ��ִ����󣬶������AutoMapper��ӳ������Լ������������߼���XXXManager��

### 5. Project.EFCore

ʵ���ܲ㣺ͬʱ�ǻ��ڴ洢�ֿ��ʵ��

### 5. Project.Miggration

����Ǩ�ƹ���

## Ȩ����֤˵����

