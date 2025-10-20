import { Todo } from '@/types/todo'

const API_BASE = 'https://localhost:7286/api/Todos'

export const todoApi = {
  async getTodos(): Promise<Todo[]> {
    const res = fetch(API_BASE)
    return (await res).json()
  },
}
