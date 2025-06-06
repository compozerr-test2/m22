import React from "react"
import { createFileRoute } from '@tanstack/react-router'
import M22Component from '../../m22-component'

export const Route = createFileRoute('/m22/')({
  component: RouteComponent,
})

function RouteComponent() {
  return (
    <div>
      <M22Component name="World!" />
    </div>
  )
}
