# RuPeng.RestTemplateCore

模仿Java中的RestTemplate实现的自动到Consul中进行服务解析和简单负载均衡，自动把http://ProductService/api/Product/这样用服务名字的虚拟路径转换为http://192.168.1.21:5000/api/Product/这样实际的地址
