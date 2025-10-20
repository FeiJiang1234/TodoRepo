'use client'

import { todoApi } from '@/services/todoApi'
import { Todo } from '@/types/todo'
import React, { useEffect, useState } from 'react'

export default function TodoPage() {
  const [todos, setTodos] = useState<Todo[]>([])
  const [loading, setLoading] = useState(false)
  const [error, setError] = useState<string>('')

  const loadTodos = async () => {
    try {
      setLoading(true)
      const data = await todoApi.getTodos()
      console.log(data)
      setTodos(data)
    } catch (error) {
      setError(error instanceof Error ? error.message : 'Failed to load todos')
    } finally {
      setLoading(false)
    }
  }
  useEffect(() => {
    loadTodos()
  }, [])

  return (
    <div>
      <h1>My todos</h1>
      {todos.length > 0 && (
        <div>
          {todos.map((t, idx) => (
            <div key={t.id}>
              <h5>{t.title}</h5>
            </div>
          ))}
        </div>
      )}
    </div>
  )
}
