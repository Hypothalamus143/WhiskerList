# Review for Rheyvene Balogbog

**Link:** [https://github.com/r-yvn/WhiskerList](https://github.com/r-yvn/WhiskerList)

---

## Project Structure Rating

### File and folder structure — 3/5
My problem stems from the fact that there are two `app.css`'s. One from the `Styles`, and the other at `wwwroot`. I'm pretty sure the former is for the tailwind to compile. Ideally, you would name the former `input.css` or at least not the same and not use that name for another CSS file again. Lastly, there are three CSS files in the `wwwroot`. The `app.css`, the `tailwind.css` (I assume the result of tailwind) and a theme. Personally, I think that theme and the `tailwind.css` might be reasonable, but the `app.css` is completely useless and will simply confuse the program on which style to use. Furthermore I still think that there should only be one CSS file there, `theme.css` is unnecessary but I guess is tolerable.

### Naming of files/folders — 3/5
The main `.csproj` still uses `MyBlazorApp` name rather than using the name of the project, which is `WhiskerList`. It is a bit problematic because all the code that references it now uses `MyBlazorApp.Models`, `MyBlazorApp` namespace, etc. While this might work, this is definitely not production ready and is generally frowned upon by the development community. And as mentioned in my previous review, there are two `app.css`, which is very redundant.

### Code organization — 4/5
The code organization itself is fine. Comments are also added so understanding the intent is easy. However, using `MyBlazorApp.Models` instead of using `WhiskerList.Models` still throws me off.

### Commit names/messages — 4/5
Pretty good commit messages. This is how I would personally write commit messages myself. Simple, concise yet delivers the message clearly. The only problem I have is it's spelt "refactor" not "refractor".

### Overall repository organization and cleanliness — 3/5
Overall the repository organization is satisfactory, noting the problems where `MyBlazorApp` namespace is used instead of the actual name of the project. Also some minor issues with the spelling of the commit messages. And the large issue of using many CSS files and using the same file names. But overall very solid architecture.

---

## Front-End Rating

### Layout and visual presentation — 5/5
The layout is good. Very simple and minimalist. It's not modern maybe in the current industry standards but it fits my taste.

### Usability and navigation — 4/5
The navigation is pretty straightforward. No problem when it comes to navigating, although modern standards would probably put transitions but that usually comes at the price of performance. The problem lies in fact that there is an unhandled exception, probably because it is trying to use a CSS that does not exist so it bug me a bit.

### Consistency — 5/5
It is very consistent. While I do think the design can be better, since all the pages can be better so by definition it is consistent. It also reuses the same fonts so it's not cluttered.

### Readability — 4/5
It uses black font and a light background but often the font is not black enough so it is hard to read. Furthermore, that website sometimes uses grey font to indicate finished tasks, which makes it even less readable. But aside from those, it is readable and not that painful in the eyes.

### Responsiveness, if applicable — not applicable

### Overall completeness and functionality — 5/5
Very nice. It is complete for the minimum viable features of the app and is functional. While it is true that there are issues with other design aspects, overall it is not that bad that can negatively impact the website that much. So this project receives a perfect score for me.
