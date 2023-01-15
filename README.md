# Vrlingo-New
langauge learnign app!

## Inspiration

Have you ever tried speaking a new language? It’s hard right? To make it worse, there’s few opportunities to practice. You need to find a fluent speaker to practice with or spend a lot of money to hire a tutor. We want to empower everyone to practice speaking for free. 

## What it does

We are a language learning community to help you practice speaking in a new language with other people in virtual worlds. We created a credit system, called TBucks, to make this ecosystem work: You can help others practice speaking in your native tongue to gain TBucks. And then spend TBucks to practice in a new language you want to learn. 

Our platform is currently built on Quest 2 as a standalone app but it's designed to be VR device-agnostic, allowing users to use any VR headset to connect with their communities, practice their language, and benefit from the immersive environments. 

### Free Language Practice  
We want to build a community where each user is not only a student learning a new language, but also a teacher who helps others with their native language. After the user specifies which languages they know and which they want to learn, we show a live map of all the current instances that are speaking those specified languages. Then the user can choose to join as a teacher to gain TBucks or as a student to spend TBucks . This will build a language learning community and enable users to practice speaking for free. 

### Situational 
Through our application, users can gain fluency by participating in different scenarios, such as eating at a restaurant, shopping at a store, or going to the park. These environments contain fully interactable props and allow for greater suspension of disbelief during roleplaying in a new language. 

### Interactions
Engage with contextually-driven prompts that help support multi-user conversations for learning a new language. For example, when the user picks up some money in the VR restaurant, they are prompted via a hovering interface a few different conversation starters based on the money object, such as “Buy some food with money.” This incites a conversation between the user holding the money and another user in the VR restaurant. 

## How we built it

We use Unity and XR Interaction Toolkit to create the app. The multiplayer networking, VOIP, synced variables and avatar sync are created using Normcore. 

## Challenges we ran into

One problem that we ran into includes networking issues. We found that when we started including our networking code, we were unable to connect with servers. After a bit of debugging, we learned that the MIT guest Wi-Fi blocked the specific port that Normcore was using for multiplayer transforms and VOIP. Because of this, we were forced to test on mobile hotspots for the duration of the hackathon. 

## Accomplishments that we're proud of
We used 15 branches, 149 commits and 3 published builds at different stages of the hackathon. 

## What's next for Vrlingo
Vrlingo aims to democratize immersive language practice to the masses. This could be a successfully startup due to our clear problem statement and our value proposition. We imagine a world where gaining fluency in new languages is made more accessible through the power of immersion and interactivity.

## Monetization
There are three ways we could monetize in the future. 

### Ads
We can place immersive ads in the VR world. For example, a branded soda in the restaurant world, or make branded coffee shop as a world for users to practice speaking in. 

### Professional Tutors   
Some users may appreciate professional tutors such as 1:1 lessons in addition to the free community support. Hence, we can offer classes and take a percentage of the fee.  

### Subscriptions 
We can offer a monthly subscription where users can gain additional features such as show hints to pronounce when grabbing objects, special status icons, and remove ads. 

