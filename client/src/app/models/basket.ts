export interface Basket {
    id: number
    buyerId: string
    items: BasketItem[],
    paymentIntentId?: string,
    clientSecret?: string,
  }
  
  export interface BasketItem {
    id: number
    name: string
    productId: number
    price: number
    pictureUrl: string
    brand: string
    type: string
    quantity: number
  }
  