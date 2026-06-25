import Link from "next/link";


export default function Header() {
  return (  

 <div className="w-full absolute text-white z-10">
 <nav className="container relative flex flex-wrap items-center justify-between mx-auto p-8"></nav>
<Link href="/" className="font-bold text-3xl">
        Home Page
      </Link>
      <div className="space-x-4 text-xl">
      <Link href="/performance">
        Performance Page
      </Link>

       <Link href="/reliability" >
        Reliability Page
      </Link>

       <Link href="/scale" >
        Scale Page
      </Link>
      </div>
     </div>
  )};