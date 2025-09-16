variable "location" {
  description = "Azure region"
  type        = string
  default     = "East US"
}

variable "resource_group_name" {
  description = "Resource Group name"
  type        = string
  default     = "rg-microservices-demo"
}

variable "acr_name" {
  description = "Azure Container Registry name (must be globally unique)"
  type        = string
  default     = "nizacrdemo"
}

variable "aks_name" {
  description = "AKS cluster name"
  type        = string
  default     = "niz-aks-demo"
}
