import React from "react";

interface Props {
   name: string;
}

const M22Component = (props: Props) => {
   return (
      <div>
         Hello {props.name}
      </div>
   );
}

export default M22Component;